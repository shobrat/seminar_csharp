// Напишите программу, которая выводит третью с конца цифру 
// заданного числа или сообщает, что третьей цифры нет. 
// Например : 456  =>  6 7812  =>  8 91  =>  Третьей цифры нет

Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());

// if (num >= 1000 && num <= 9999 || num <= -1000 && num >= -9999)
// {
//     int fullnum = num /100;
//     int remainder = fullnum % 10;
//     Console.WriteLine($"{num} => {remainder}");
// }

// if (num >= 100 && num <= 999 || num <= -100 && num >= -999)
// {
//     int remainder = num % 10;
//     Console.WriteLine($"{num} => {remainder}");
// }
// if (num >= 1 && num <= 99 || num <= -1 && num >= -99)
// {
//     Console.WriteLine("Третьей цифры нет");
// }

int number = num;
if (num < 0) num = num * -1;

if (num >= 100)
{
    while (num > 999)
        num /= 10; // это тоже самое что num = num / 10
    Console.WriteLine($"{number} => {num % 10}");
}
else
{
    Console.WriteLine($"{number} => Третьей цифры нет");
}