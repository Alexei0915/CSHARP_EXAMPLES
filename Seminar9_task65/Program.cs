// Задача 65: Задайте значение M и N . Напишите программ,которая выведет все натуральные числа в промежутке от M до N.
Console.WriteLine("Начало диапозона");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Конец диапозона");
int n = int.Parse(Console.ReadLine());
void Numbers(int i)
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

int j = m;

Numbers(j);