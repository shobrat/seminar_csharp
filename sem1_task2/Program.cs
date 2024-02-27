// Напишите программу, которая на вход принимает целое число N, 
// а на выходе показывает все целые числа в промежутке от -N до N. 
// Примеры 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4 2 => -2, -1, 0, 1, 2

Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 0)
{
    num = num * -1;
}

int size = num;
//int otr = - num;
int count = -num;

while (count < size)
{

    Console.Write($"{count} ");
    count++;
}

