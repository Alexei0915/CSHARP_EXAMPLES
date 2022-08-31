// Задача 53: Задайте двумерный массив.
//Напишите программу,которая поменяет местами первую и последнюю строку массива.
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
        Console.WriteLine ();
        for (int j = 0; j < matr.GetLength(1); j++)
        {
             Console.Write ($"{matr[i, j]+ " "}");
        }
        Console.WriteLine($"{matr [i, matr.GetLength(1)- 1]}");
        Console.WriteLine();
    }
}

PrintArray(array);

void swap(int[,]arr)
{
 for (int j = 0; j < arr.GetLength(1)- 1; j++)
 {
    int temp = 0;
    temp = arr [0, j];
    arr [0, j]= arr[arr.GetLength(0)- 1,j];
    arr [arr.GetLength(0)- 1, j]= temp;

 }
}
void Print2Array(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr [i, j] < 0 ) Console.Write(array[i, j]+ " ");
            else Console.Write(" "+ array[i, j]+" ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}


Console.WriteLine();
swap(array);
Print2Array(array);
