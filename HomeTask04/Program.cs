// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите третье число");
double num3 = Convert.ToDouble(Console.ReadLine());
double maximum = num1;
if (num2 > maximum)
{
    maximum = num2;
}
if (num3 > maximum)
{
    maximum = num3;
}
Console.WriteLine($"Максимальное из этих трех чисел - {maximum}");