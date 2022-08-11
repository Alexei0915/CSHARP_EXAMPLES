//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число");
int a = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(a);
Console.WriteLine("вторая цифра этого числа  " +stringNumber [1]);