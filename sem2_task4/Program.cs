// Напишите программу, которая выводит третью слева цифру заданного числа или сообщает, что третьей цифры нет.
// 456 => 6
// 7812 => 1
// 91 => Третьей цифры нет

Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
int number = num;

if (num < 0) num = num * -1;

if (num >= 100)
{
    while (num > 999) num /= 10; // Это тоже самое что num=num/10
    Console.WriteLine($"{number} => {num % 10}");
}
else
{
    Console.WriteLine($"{number}=> Третьей цифры нет");
}
