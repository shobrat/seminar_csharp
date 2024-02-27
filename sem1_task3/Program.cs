
Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num <= 999)
{
    int sum = num / 100 + num % 10;
    Console.WriteLine($"{sum}");
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
