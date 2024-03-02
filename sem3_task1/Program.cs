// Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве. 
// Программа должна выдать ответ: Да/Нет. 

// Примеры [1 3 4 19 3], 8 => Нет [-4 3 4 1], 3 => Да
// int[] array1= new int[8]; //В таком случае в массиве будут только нули
// int[] array2 = new int[8] { 4, 6, 7, 9, 3, 2, 4, 5 };
// int[] array3 = new int[] { 4, 6, 7, 8, 9, 0, 3, 2 };

Console.WriteLine("Задайте целое число для поиска в массиве");
int targetNum = Convert.ToInt32(Console.ReadLine());
int[] array = { 5, 6, 7, 8, 2, 3, 4, 5, 6 };
bool res = false;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == targetNum)
    {
        res = true;
        break;
    }
}

string result = res ? "Да" : "Нет"; //тернарный оператор
Console.WriteLine(result); 