// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

void CubesTable(int num)
{
    int i = 1;
    while (i <= num)
    {
        Console.WriteLine($"{i,3} | {i * i * i}");
        i++;
    }
}

Console.WriteLine("Введите натуральное число");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 1) Console.WriteLine("Это не натуральное число. Попробуйте еще раз.");
else CubesTable(n);