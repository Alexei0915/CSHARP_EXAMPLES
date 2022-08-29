//Задача 48: Задайте двумерный массив размером m на n, каждый элемент в массиве находится по формуле :Amn=m+n.
// выведете полученный массив на экран.
Console.Write("Введите m : ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите n : ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[m, n];

// int[,] array = new int[m, n];

// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        array [i, j] = i + j;
    }

PrintArray (array);