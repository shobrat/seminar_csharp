// Дано натуральное трёхзначное число. Создайте массив, 
// состоящий из цифр этого числа. Младший разряд числа 
// должен располагаться на 0м индексе массива, 
// старший – на 2-м. 

// Пример 456  =>  [6 5 4] 781  =>  [1 8 7]

// Console.WriteLine("Введите трехзначное число");
// int num = Convert.ToInt32(Console.ReadLine());

// int count = 0;
// int size = 3;
// int num1 = num / 100;
// int num2 = num % 10;
// int num3 = num / 10 % 10;

// while (count < size)
// {
//     //Console.Write($"{num} => {num2} {num3} {num1}");
//     count = count + 1;
// }
// Console.Write($"{num} => [{num2} {num3} {num1}]");
Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[3];
int i = 0;

if (num >= 100 && num <= 999)
{

    while (num > 0)
    {
        Array[i] = num % 10;
        i++;
        num /= 10; //num = num / 10; 
    }
    for (int j = 0; j < Array.Length; j++)
    {
        Console.Write($"{Array[j]} ");
    }
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число");
}



