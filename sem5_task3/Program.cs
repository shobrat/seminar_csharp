// Задайте двумерный массив из целых чисел. Сформируйте новый одномерный массив, состоящий из средних 
// арифметических значений по строкам двумерного массива.
// Пример
// 2 3 4 3
// 4 3 4 1  => [3 3 5]
// 2 9 5 4

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i], 4}");
    }
}

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

double[] AverageRows(int[,] matrix)
{
    double[] array = new double[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        double sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        double tempAverage = sum / matrix.GetLength(1);
        array[i] = tempAverage;
    }
    return array;
}
int[,] matr = CreateMarixRndInt(3, 4, 0, 10);
PrintMatrix(matr);
Console.WriteLine();
double[] mass = AverageRows( matr);
PrintArray(mass);