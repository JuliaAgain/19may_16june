// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2) // c[i, j] = a[i,1]*b[1, j] + a[i, 2]*b[2, j] +....
{
    int[,] newMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                sum = sum + matrix1[i, k] * matrix2[k, j];
            }
            newMatrix[i, j] = sum;
        }
        
    }
    return newMatrix;
}

int[,] array1 = CreateMatrixRndInt(3, 2, 0, 10);
PrintMatrix(array1);
Console.WriteLine();
int[,] array2 = CreateMatrixRndInt(2, 5, 0, 10);
PrintMatrix(array2);

int[,] newArray = MatrixMultiplication(array1, array2);
Console.WriteLine();
PrintMatrix(newArray);