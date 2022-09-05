// Задача 69: Рекурсия.Напишите программу,которая на вход принимет два числа А и В,и 
//возводит число А в целую степень В с помощью рекурсии.
Console.WriteLine("введите число");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("введите степень");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();

int RecursionNumbers(int n, int m)
{
    if (n == 0)
    {
        return 1;
    }

    if (n == 1)
    {
        return m;
    }
    else
    {
        return RecursionNumbers(n - 1, m) * m;


    }
}

Console.WriteLine(RecursionNumbers(n, m));
