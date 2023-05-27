// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).
Console.WriteLine("Введите номер четверти");
int quarter = Convert.ToInt32(Console.ReadLine());
if (quarter < 1 || quarter > 4) 
{
    Console.WriteLine("Некорректно задан номер четверти");
    return;
}
string result = Coordinates(quarter);
Console.WriteLine($"Четверти под номером {quarter} соответствуют координаты {result}");
string Coordinates(int q)
{
    if (q == 1) return "x > 0, y > 0";
    if (q == 2) return "x < 0, y > 0";
    if (q == 3) return "x < 0, y < 0";
    if (q == 4) return "x > 0, y < 0";
    return " ";
}