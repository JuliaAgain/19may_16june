// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] IntersectionPoint(double k1, double b1, double k2, double b2)
{
    double[] arr = new double[2];
    arr[0] = (b2 - b1) / (k1 - k2);
    arr[1] = (k1 * arr[0]) + b1;
    return arr;
}

void PrintArray(double[] arr)
{
    Console.WriteLine("");
    Console.Write("(");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine($"{arr[arr.Length - 1]})");
}

Console.WriteLine("Введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b2");
double b2 = Convert.ToInt32(Console.ReadLine());
if (k1 == k2) Console.WriteLine("Эти прямые не пересекаются.");
else
{
    double[] point = IntersectionPoint(k1, b1, k2, b2);
    PrintArray(point);
}
