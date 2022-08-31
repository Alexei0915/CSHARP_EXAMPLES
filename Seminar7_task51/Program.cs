// Задача 51 Задайте двумерный массив. Найдите сумму элементов находящуюся на главной диагонали.
Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[m, n];

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}
FillArray(array);

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write ($"[");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write ($"{matr[i, j]+ " "}");
        }
        Console.WriteLine($"{matr [i, matr.GetLength(1)- 1]}]");
        Console.WriteLine();
    }
}


int temp = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (i == j)temp = temp + array[i,j];
            
    }
}



Console.WriteLine($"сумма диагонали  {temp}");
PrintArray(array);
