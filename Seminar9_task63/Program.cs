// Задача 63: Задайте значение N.Напишите программу,которая выведет все натуральные числа в промежутке от 1 до N.

Console.WriteLine("text");
int n = int.Parse(Console.ReadLine());
void RecursionNaumbers(int i)
{
    if (i == n)
    {
        Console.Write($" {i}");
    }
    else 
    {
       
        Console.Write($" {i}");
        i++;
        RecursionNaumbers(i);
    }
}

int j = 1;

RecursionNaumbers(j);