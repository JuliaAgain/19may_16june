// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число не кратно
// второму, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно
// 12 мин

int DevidedWithoutRemainder(int arg1, int arg2)
{
    int remain = arg1 % arg2;
    return remain;
}
Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

int myresult = DevidedWithoutRemainder(num1, num2);

if (myresult == 0) Console.WriteLine("Первое число кратно второму");
else Console.WriteLine($"Первое число не кратно второму, остаток от деления -> {myresult}");
