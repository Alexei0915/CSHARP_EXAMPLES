// Задача 67: Рекурсия.Напишите программу,которая принимает на вход число и возвращает суммму его цифр. 
Console.WriteLine("введите число");
int m = int.Parse(Console.ReadLine());
int sum = 0;
Console.WriteLine();
int RecursionNumbers(int m)
{

    if (m == 0)
    {
        return 0;
    }
    else
    {
        return RecursionNumbers(m / 10) + m % 10;

    }
}

Console.WriteLine(RecursionNumbers(m));

