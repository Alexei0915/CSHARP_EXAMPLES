//Напишите программу, которая принимает на вход два числа и проверяет является ли первое число квадратом второго и на оборот.
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
if((a * a == b)||(b * b == a ))
{
    Console.WriteLine("является");
}
else 
{
    Console.WriteLine("не является");
}