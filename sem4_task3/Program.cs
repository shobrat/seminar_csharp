// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231



int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int ArrayToInteger(int[] array)
{
    int numbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        numbers = numbers * 10 + array[i];
    }
    return numbers;
}

Console.WriteLine("Введите размер массива");
int mass = Convert.ToInt32(Console.ReadLine());

int[] arrayInt = CreateArrayRndInt(mass, 1, 9);
PrintArray(arrayInt);


Console.WriteLine($"=> {ArrayToInteger(arrayInt)}");

