// Задайте массив из 12 элементов,заполненный случайными числами из промежутка -9,9.
//Найдите сумму отрицательных и положительных элементов массива.

int[] array = new int[12];
int sumPositive = 0;
int sumNegative = 0;
int len =array.Length;
int index = 0;
while(index < array.Length)
{
    array[index] = new Random().Next(-10, 10);
    index++;
}
for (int i = 0; i < len; i++)
{
    if(array[i] < 0)
    {
        sumNegative += array[i];
    }
    else
    {
        sumPositive += array[i];
    }
    Console.Write(array[i] + " ");
}
Console.WriteLine($"сумма положительных {sumPositive}, сумма отрицательных {sumNegative}");
