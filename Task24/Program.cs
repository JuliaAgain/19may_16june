// Задача 24. Напишите программу, которая на вход принимает число (А)
// и выдает сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите целое положительное число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 0)
{
    Console.WriteLine("Введено некорректное число!");
    return;
}
int s = SumNumbers(number);
Console.WriteLine($"Сумма чисел от 1 до {number} равна {s}.");

int SumNumbers(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum += i;
    }
    return sum;
}

