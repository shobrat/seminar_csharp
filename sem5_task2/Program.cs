// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами 
// (0,0); (1;1) и т.д.
// Пример

//     2 3 4 3
//     4 3 4 1
//     2 9 5 4
// =>  2 + 3 + 5 = 10

// Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами 
// (0,0); (1;1) и т.д.
// Пример

// 2 3 4 3
// 4 3 4 1
// 2 9 5 4

// => 2 + 3 + 5 = 10


int[,] CreateMarixRndInt(int rows, int colums, int min, int max)
{
    int[,] array = new int[rows, colums];
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],5}");
        }
        Console.WriteLine();
    }

}

int SummMainDiagonal(int[,] matrix)
{
    int sum = 0;
    int min = matrix.GetLength(0);
    if (matrix.GetLength(1) < min) min = matrix.GetLength(1);
    for (int i = 0; i < min; i++)
    {
        sum += matrix[i, i];
    }
    return sum;
}

int[,] matr = CreateMarixRndInt(7, 5, 0, 10);

PrintMatrix(matr);
Console.WriteLine();
Console.WriteLine(SummMainDiagonal(matr));
