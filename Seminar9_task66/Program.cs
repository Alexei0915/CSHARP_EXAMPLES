// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


int m = InputNum("Введите m: ");
int n = InputNum("Введите n: ");
int i = m;

if (m > n)
{
    m = n;
    n = i;
}

PrintSum(m, n, i = 0);

void PrintSum(int m, int n, int sum)
{
    sum = sum + n;
    if (n <= m)
    {
        Console.Write($"Сумма элементов= {sum} ");
        return;
    }
    PrintSum(m, n - 1, sum);
}

int InputNum(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}