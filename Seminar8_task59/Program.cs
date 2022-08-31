//Задача 59:  Задайте двумерный массив из целых чисел.
//Напишите программу, которая удалит строку и столбец,
//на пересечении которых расположен наименьший эллемент массива.
int m = Convert.ToInt32(new Random().Next(3, 5));// randomly select how many rows wil be in array (случайным образом выберите, сколько строк будет в массиве)
int n = m + Convert.ToInt32(new Random().Next(3, 5));// randomly select how many colums wil be in array,wich is larger that m (случайным образом выберите, сколько столбцов будет в массиве,который больше m)
Console.WriteLine();

int[,] array = new int[m, n];

void FillPrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(-1, 10);
            if (arr[i, j] < 0) Console.Write(arr[i, j] + " ");
            else Console.Write(" " + arr[i, j] + " ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
    Console.WriteLine();
}

FillPrintArray(array);

void FindMinArray(int[,] arr, out int row, out int col)
{
    int min = arr [0, 0];
    row = 0;
    col = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < min) 
            {
                min = arr[i, j];
                row = i;
                col = j;
            }
                   
        }
    }   
}

int x = 0, y = 0;
FindMinArray(array,out x, out y);
Console.WriteLine(x);
Console.WriteLine(y);

int[,] CutArray (int[,] arr, int row, int col )
{
    int[,] arr1 = new int[arr.GetLength(0)- 1, arr.GetLength(1)-1];
    int shifti=0;
    int shiftj=0;
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            if (i < row )shifti = 0;
            else shifti = 1;
            if (j < col )shiftj = 0;
            else shiftj = 1;
            arr1[i, j] = arr[i + shifti, j + shiftj];
        }
    }

    return arr1;
}

Console.WriteLine();
FillPrintArray(CutArray (array, x, y));
