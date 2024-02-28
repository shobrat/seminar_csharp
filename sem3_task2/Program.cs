// Задайте массив из 10 элементов, заполненный числами из промежутка [-10, 10]. 
// Замените отрицательные элементы на положительные, 
// а положительные на отрицательные. 
// Пример [1 -5 6] => [-1 5 -6]

int[] array = new int[10] {1, -5, 6, 3, -4, 1, 9, -6, 2, -7};

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}

Console.WriteLine();

for (int i = 0; i < array.Length; i++)
{
    array[i] *= -1; //array[i] = array[i] * -1;
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}
Console.WriteLine();