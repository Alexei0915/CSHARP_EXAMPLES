// Напишите программу которая принимает на вход число N и выдает произведение чисел от 1 до N.
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());
int count = 1;
for (int i = 1; i <=N; i++)
{
    count= count * i;
}
Console.WriteLine(count);