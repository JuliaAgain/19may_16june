// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int WriteSecondDigitOfThree(int num)
{
   int result = (num %100)/10;
   return result;
}
Console.WriteLine("Введите трехзначное число число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 || number > 999) Console.WriteLine("Это не трехзнанчое число!");
else 
{
    int secondDigit = WriteSecondDigitOfThree(number);
    Console.WriteLine($"Вторая цифра числа {number} -> {secondDigit}");
}