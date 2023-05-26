// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

void SquareTable(int num)
{
    int i = 1;
    while (i <= num)
    {
        Console.WriteLine($"{i,3} {i * i,4}");
        i++;
    }
}

Console.WriteLine("Введите натуральное число");
int n = Convert.ToInt32(Console.ReadLine());

SquareTable(n);
