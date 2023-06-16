// Задача 69: Напишите программу, которая на вход 
// принимает два числа A и B, и
// возводит число А в целую степень B 
// с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int Exponentiation(int number, int exp)
 {
     if (exp == 0) return 1;
     return number * Exponentiation(number, exp - 1);
 }

Console.WriteLine("Введите натуральное число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Число {num1} в степени {num2} равно {Exponentiation(num1, num2)}");