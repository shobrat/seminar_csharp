Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());

int FirstDigit = num / 100;
int SecondDigit = num % 10;

if (num >= 100 && num <= 999 || num >= -999 && num <= -100) // знак || означает логическое значение - или
{
    int result = FirstDigit*10 + SecondDigit;
    Console.WriteLine($"a = {num} => {result}");
}
else
{
    Console.WriteLine("Вы ввели некорректное число");
}
