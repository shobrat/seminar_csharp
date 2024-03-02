// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17

Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());

int numCheck = num;
if (num < 0) numCheck = -num;

if (numCheck >= 100 && numCheck <= 999)
{
    int sumDigits = numCheck / 100 + numCheck % 10;
    Console.WriteLine($"{num} => {sumDigits}");
}
else
{
    Console.WriteLine("Некорректный ввод");
}


// int firstnumber = num / 100;
// int secondnumber = num % 10;
// int sum = firstnumber + secondnumber;

// Console.WriteLine($"{firstnumber}");
// Console.WriteLine($"{secondnumber}");

//Console.WriteLine($"{sum}");