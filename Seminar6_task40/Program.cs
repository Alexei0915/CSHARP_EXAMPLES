// Задача 40: Напишите программу,которая принимает на вход три числа
// и проверяет,может ли существовать треугольник с сторонами такой длины.
bool isTriangleExist(int A, int B, int C)
{
    if (A < B + C && B < A + C && C < B + A)
    {
        return true;
    }
    return false;
}
Console.WriteLine("Enter A");
int A = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter B");
int B = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter C");
int C = int.Parse(Console.ReadLine()!);


if (isTriangleExist(A, B, C))
{
    Console.Write("Yes");
}
else
{
    Console.Write("No");
}