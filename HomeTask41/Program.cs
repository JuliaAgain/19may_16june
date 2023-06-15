// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3



int[] EnterArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите элемент массива");
        int element = Convert.ToInt32(Console.ReadLine());
        array[i] = element;
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.WriteLine("");
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}

int CountPositiveNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count+=1;
    }
    return count;
}

Console.WriteLine("Введите число элементов в массиве");
int m = Convert.ToInt32(Console.ReadLine());
int[] row = EnterArray(m);
PrintArray(row);
int result = CountPositiveNumbers(row);
Console.WriteLine($"В этом массиве {result} чисел больше 0.");
