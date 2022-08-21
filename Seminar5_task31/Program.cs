// See https://aka.ms/new-console-template for more information
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
