// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool IsItPalindrome(int n)
{
    int firstDigit = n / 10000;
    int secondDigit = (n / 1000) - firstDigit*10;
    int fifthDigit = n % 10;
    int fourthDigit = (n % 100)/10;
    if ((firstDigit == fifthDigit) && (secondDigit == fourthDigit)) return true;
    return false;
}

Console.WriteLine("Введите пятизначное целое число.");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0) num = num*(-1);
if ((num < 100000) && (num > 9999))
{
    bool result = IsItPalindrome(num);
    if (result == true) Console.WriteLine($"Число {num} является палиндромом.");
    else Console.WriteLine($"Число {num} не является палиндромом.");
}
else Console.WriteLine("Это не пятизначное число. Введите корреткное число.");