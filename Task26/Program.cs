// Задача 26. Напишите программу, которая
// принимает на вход число и выдает количество цифр в нем.
// 456 -> 3
// 89126 -> 5

int CountDigits(int n)
{
    int digits = 0;
    if (n == 0) return 1;
    while (n != 0)
    {
        digits++;
        n /= 10;
    }
    return digits;
}
Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Число {num} содержит {CountDigits(num)} цифр.");


