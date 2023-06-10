// Задача 30. Напишите программу, которая выводит массив из 8 элементов,
// заполненных нулями и единицами в случайном порядке.

void FillArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(2);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
int[] row = new int[8];

FillArray(row);

PrintArray(row);