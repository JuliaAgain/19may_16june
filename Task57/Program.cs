// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

int[,] CreateFillMatrix(int m, int n)
{
    int[,] arr = new int[m, n];
    var rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = rnd.Next(1, 10);
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

int[] FromMatrixToArray(int[,] matr)
{
    int[] arr = new int[matr.GetLength(0) * matr.GetLength(1)];
    int index = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            arr[index++] = matr[i, j];
        }
    }
    return arr;
}

void CountElements(int[] arr)
{
    int currentValue = arr[0];
    int count = 1;
    for (int i = 1; i < arr.Length; i++)
    {
        if (currentValue == arr[i])
        {
            count++;
        }
        else
        {
            Console.WriteLine($"There are {count} elements {currentValue}");
            currentValue = arr[i];
            count = 1;
        }
    }
    Console.WriteLine($"There are {count} elements {currentValue}");
}

void PrintArray(int[] arr)
{
    foreach (var item in arr)
    {
        Console.Write(item + " ");
    }
}

int[,] matrix = CreateFillMatrix(5, 5);
PrintMatrix(matrix);
Console.WriteLine();

int[] array = FromMatrixToArray(matrix);
Array.Sort(array);
PrintArray(array);
Console.WriteLine();
CountElements(array);