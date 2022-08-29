﻿// Задача 46: Задайте двумерный массив размером m X n , заполненный случайными целыми числами.
// m =3,n=4
Console.Write("Введите высоту матрицы: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите длину матрицы: ");
int n = int.Parse(Console.ReadLine());

int [,] array = new int [m,n];

void FillArray (int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1);j++)
        {
            matr [i,j] = new Random().Next(1,10);
        }
    }
}

void Print (int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1);j++)
        {
            Console.Write(matr [i,j]+" ");
        }
        Console.WriteLine();
    }
}
 
FillArray(array);
Print (array);