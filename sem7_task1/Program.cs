﻿// Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от 1 до N. 

// Указание Использовать рекурсию. 
// Не использовать цикл. 
// Пример N=5 => 1 2 3 4 5

void GetNaturalnumbers(int num)
{
    if (num == 0) return;
    GetNaturalnumbers(num-1); //Рекурсивный вызов
    Console.Write($"{num} "); //Рекурсивный вывод
    //Если поменять местами рекурсивный вызов и вывод,
    //тогда ответ будет без стека и вывод будет прямым, это называетс хвостовая рекурсия
    //т.е. ответ будет таким: 5 4 3 2 1
}

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());


GetNaturalnumbers(number);