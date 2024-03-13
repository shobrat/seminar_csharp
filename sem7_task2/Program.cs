// Напишите программу, которая будет принимать на вход число 
// и возвращать сумму его цифр. Указание Использовать рекурсию. 
// Пример 123 => 6 63 => 9

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine()); 

static int GetSumNumbers(int number) // принимает следующие значения после деления на 10: 123 12 1 0
{
     if(number == 0) return 0;
     return number % 10 + GetSumNumbers(number/10); // принимает следующие значения после деления на % 10: 3 2 1 0 и после сложения ответ: 6
}

Console.WriteLine(GetSumNumbers(num));

