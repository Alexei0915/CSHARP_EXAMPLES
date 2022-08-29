// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.WriteLine("введите количество строк");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int n = int.Parse(Console.ReadLine());
double[,] numbers = new double[m, n];
FillArray(numbers);
PrintArray(numbers);

void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100))/ 10 ;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] );
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}