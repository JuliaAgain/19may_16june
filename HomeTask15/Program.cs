// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

bool IsItHoliday(int num)
{
    if (num == 6 || num == 7) return true;
    else return false;
}

Console.WriteLine("Введите номер дня недели");
int dayNumber = Convert.ToInt32(Console.ReadLine());
if (dayNumber < 1 || dayNumber > 7)
{
    Console.WriteLine("Некорректный номер дня недели");
}
else 
{
    bool result = IsItHoliday(dayNumber);
    if (result == true)     Console.WriteLine("Это выходной день!");
    else Console.WriteLine("Это НЕ выходной!");
}
