// Напишите программу,которая принимает на вход координаты точки (X и Y),причем Х=0 и y=0 и выдает номер четверти плоскости,в которой находится эта точка.
Console.WriteLine("Введите x");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y");
int y = Convert.ToInt32(Console.ReadLine());
if (x > 0 & y > 0)
{
    Console.WriteLine("1-я четверть");
}
if (x < 0 & y > 0)
{
    Console.WriteLine("2-я четверть");
}
if (x < 0 & y < 0)
{
    Console.WriteLine("3-я четверть");
}
if (x > 0 & y < 0)
{
    Console.WriteLine("4-я четверть");
}
