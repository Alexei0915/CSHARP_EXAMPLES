// Задача 44: Не использую рекурсию,выведете первые N  чисел Фибоначчи.
//Первые два числа Фибоначчи:0 и 1.
Console.WriteLine("Enter an integer number: ");
int n = Convert.ToInt32(Console.ReadLine());

int [] Fibonacci = new int[n];

Fibonacci [0] = 0;
Fibonacci [1] = 1;

for (int i = 2; i < n;i++)
{
    Fibonacci[i] = Fibonacci[i-1] + Fibonacci[i-2];
}

for (int i = 0; i < n;i++)
{
    Console.Write(Fibonacci[i]);
}