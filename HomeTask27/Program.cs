// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{
    number *= (-1);
}

int s = SumOfDigits(number);
Console.WriteLine($"Сумма цифр в числе {number} равна {s}.");

int SumOfDigits(int num)
{
    int result = 0;
    while (num > 0)
    {
        result = result + (num%10);
        num = num / 10;
    }
    return result;
}
    


