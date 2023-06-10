// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число:");
int b = Convert.ToInt32(Console.ReadLine());
if (b < 0)
{
    Console.WriteLine("Введено некорректное число!");
    return;
}
int result = Exponentiation(a, b);
Console.WriteLine($"Число {a} в степени {b} равно {result}.");

int Exponentiation(int num1, int num2)
{
    if (num2 == 0) return 1;
    int exp = num1;
    for (int i = 1; i < num2; i++)
    {
        exp *= num1;
    }
    return exp;
}
