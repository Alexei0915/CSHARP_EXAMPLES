// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число");
int a =int.Parse(Console.ReadLine());
int index = 1;
while(index<=Math.Abs(a))
{
    Console.Write($" {index*index*index}, ");
    index++;
    
}