﻿// Задача 55 : Задайте двумерный массив.
// Напишите программу, которая заменяет строки на столбцы.

int m = Convert.ToInt32(new Random().Next(3 , 5));// randomly select how many rows wil be in array (случайным образом выберите, сколько строк будет в массиве)
int n = m + Convert.ToInt32(new Random().Next(3 , 5));// randomly select how many colums wil be in array,wich is larger that m (случайным образом выберите, сколько столбцов будет в массиве,который больше m)
Console.WriteLine();

int[,] array = new int[m, n];
void FillPrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(-10, 11);
            if (arr[i, j] < 0)Console.Write(arr[i, j] + " ");
            else Console.Write(" " + arr[i, j] + " ");
        }
    }
}