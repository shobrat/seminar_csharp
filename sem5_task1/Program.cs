﻿// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы 
// на их квадраты.
// Пример
 //   0  1  2  3
// 0  2  3  4  3
// 1  4  3  4  1 
// 2  2  9  5  4
// => 
// 0  4  3  16  3
// 1  4  3  4  1
// 2  4  9  25 4

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    //   0      1
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }

    return matrix;
}



void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine();
    }
}

void ReplaceEvenIdxElemToSquare(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i += 2)
    {
        for (int j = 0; j < matrix.GetLength(1); j += 2)
        {
            matrix[i, j] *= matrix[i, j];
        }
    }
}

int[,] array2d = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(array2d);

Console.WriteLine();

ReplaceEvenIdxElemToSquare(array2d);
PrintMatrix(array2d);