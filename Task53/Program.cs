// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

int[,] CreateMatrix(int rows, int columns, int min, int max)
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
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine();
    }
}
void SwapFirstLastRow(int[,] arr)
{
    int lastRow = arr.GetLength(0) - 1;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        int temp = arr[0, i];
        arr[0, i] = arr[lastRow, i];
        arr[lastRow, i] = temp;
    }
}
int[,] array2d = CreateMatrix(3, 4, 10, 15);
PrintMatrix(array2d);
Console.WriteLine();
SwapFirstLastRow(array2d);
PrintMatrix(array2d);