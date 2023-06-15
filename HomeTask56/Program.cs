// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

int[,] CreateFillMatrix(int m, int n, int min, int max)
{
    int[,] arr = new int[m, n];
    var rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return arr;
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],4}");
        }

        Console.WriteLine();
    }
}

int[] SumsOfNumbers(int[,] matrix) // метод создает одномерный массив, каждый элемент которого, - это сумма элементов в соответсвующем ряду исходной марицы
{
    int[] rowMins = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum+= matrix[i, j];
        }
        rowMins[i] = sum;
    }
    return rowMins;
}

int NumOfMinElement(int[] array) // метод для нахождения индекса минимального элемента в одномреном массиве
{
    int minNum = array[0];
    int indexMin = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minNum)
        {
            minNum = array[i];
            indexMin = i;
        }
    }
    return indexMin;
}

int[,] matr = CreateFillMatrix(4, 4, 0, 10);
PrintMatrix(matr);
int[]  sums = SumsOfNumbers(matr);
int result = NumOfMinElement(sums);
Console.WriteLine($"Наименьшая сумма элементов в {result}-й строке этого массива.");

