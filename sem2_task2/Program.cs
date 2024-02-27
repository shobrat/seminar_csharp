// Напишите программу, которая принимает на вход трёхзначное число 
// и возводит вторую цифру этого числа в степень, равную третьей цифре. 
// Примеры 487 => 8^7 = 2 097 152 254 => 5^4 = 625 617 => 1


Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());

int SecondDigit = num / 10 % 10;
int TrirdDigit = num % 10;

int count = 0;
int result = 1;

if (num >= 100 && num <= 999 || num >= -999 && num <= -100)
{
    while (count < TrirdDigit)
    {
        result = result * SecondDigit;
        count = count + 1;
    }
    Console.WriteLine($"{num} => {result}");
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
