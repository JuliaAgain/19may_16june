// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumbersInRange(int num1, int num2)
{
    if (num1 == num2) return num2;
    return num1 + SumNumbersInRange(num1 + 1, num2);
}

Console.WriteLine("Введите два натуральных числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 < 1 || number2 < 1) Console.WriteLine("Некорректный ввод. Оба числа должны быть натуральными."); // исключила 0, так по заданию нао найти сумму натуральных элементов
else if (number1 < number2)
{
    int result = SumNumbersInRange(number1, number2);
    Console.WriteLine($"Сумма натуральных чисел в интервале между {number1} и {number2} равна {result}");
}
else if (number1 > number2)
{
    int result = SumNumbersInRange(number2, number1);
    Console.WriteLine($"Сумму чисел в интервале между {number2} и {number1} равна {result}");
}
else if (number1 == number2)
{
    Console.WriteLine($"Сумму чисел в интервале между {number2} и {number1} равна {number1}");
}


