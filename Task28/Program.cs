// Задача 28. Напишите программу, которая на вход принимает число N
// и выдает произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите целое положительное число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 0)
{
    Console.WriteLine("Введено некорректное число!");
    return;
}
int s = Factorial(number);
Console.WriteLine($"Произведение чисел от 1 до {number} равно {s}.");

int Factorial(int num)
{
    int result = 1;
    for (int i = 1; i <= num; i++)
    {
        checked 
        {
            result*=i;
        }
    }
    return result;
}
