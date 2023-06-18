﻿// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
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
            Console.Write($"{matrix[i, j],6}");
        }
        Console.WriteLine();
    }
}



int[,] SortMatrixRowsDecreasingOrder(int[,] matrix)
{
    for (int k = 0; k < matrix.GetLength(0); k++) // проходим по каждому ряду
    {
        for (int i = 0; i < matrix.GetLength(1); i++)         // 2 цикла -  сортировка пузырьком
        {
            for (int j = 0; j < matrix.GetLength(1) - 1 - i; j++)
            {
                int temp = 0;
                if (matrix[k, j] < matrix[k, j + 1])
                {
                    temp = matrix[k, j];
                    matrix[k, j] = matrix[k, j + 1];
                    matrix[k, j + 1] = temp;
                }
            }
        }
    }
        return matrix;
    }

    int[,] array2d = CreateMatrixRndInt(4, 4, 0, 10);
    PrintMatrix(array2d);
    Console.WriteLine("Матрица с упорядоченными в порядке убывания рядами:");
    int[,] sortedArray = SortMatrixRowsDecreasingOrder(array2d);
    PrintMatrix(sortedArray);
