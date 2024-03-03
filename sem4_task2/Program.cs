// Задайте массив из N случайных целых чисел (N вводится с клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.
// Пример
// [1 5 11 21 81 4 0 91 2 3]
// => 2

Console.WriteLine("Введите размер массива");
int count = Convert.ToInt32(Console.ReadLine());

// int[] FindNumbers(int[] array)
// {
//     int number = array[i];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 7 == 0)
//         {
//             number++;
//         }
//     }
//     return number;
// }


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


// int CountPrimeNumbers(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         int num = array[i];
//         if (IsNumberDel7(num))
//         {
//             count++;
//         }
//     }
//     return count;
// }

// static bool IsNumberDel7(int num)
// {
//     int number = num % 10;
//     for (int i = 1; i < Math.Sqrt(num); i++)
//     {
//         if (num % 7 == 0 && number == 1)
//         {
//             return true;
//         }
//     }
//     return false;
// }

int FindResult(int end, int multiple, int[] arrInt)
{
    int counter = 0;
    for (int i = 0; i < arrInt.Length; i++)
    {
        if (arrInt[i] % 10 == end && arrInt[i] % multiple == 0) counter++;
    }
    return counter;
}

int minimum = 1;
int maximum = 100;

int[] array = CreateArrayRndInt(count, minimum, maximum);
PrintArray(array);

//int countPrimeNumbers = CountPrimeNumbers(array);
Console.WriteLine();
Console.WriteLine(FindResult(1,7,array));
