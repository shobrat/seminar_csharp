Console.WriteLine("Введите натуральное число");
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

