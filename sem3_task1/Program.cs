// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если второе число некратно первому, то программа выводит остаток от деления.
// Примеры
// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет, 1


Console.WriteLine("Введите первое целое число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите первое целое число");
int num2 = Convert.ToInt32(Console.ReadLine());

int remainder = num1 % num2;

if (remainder == 0)
{
    //Первое число является кратным второму
    Console.WriteLine($"{num1}, {num2} => Да");

}

else 
{
    Console.WriteLine($"{num1}, {num2} => {remainder}");
}
