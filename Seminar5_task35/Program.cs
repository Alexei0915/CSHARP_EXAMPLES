// Задайте одномерный массив из 123 случайных чисел.Найдите колличество элементов массива,значение которых лежат в отрезке от 10 до 99.
void FillArray(int [] arr)
{
    int length= arr.Length;
    for (int i= 0;i <length ; i++)
    {
        arr[i] = new Random().Next(0,130);
    }
}
int[] array = new int[123];

FillArray(array);
int count = 0;
for(int i = 0;i <array.Length;i++ )
{
 if (array[i] > 10 & array[i] < 99 )
 {
     count++;
 }
}
Console.WriteLine(count); 
PrintArray(array);

Console.WriteLine();
Console.WriteLine();



void PrintArray(int [] arr) 
{
    int length= arr.Length;
    for (int i= 0;i < length ;i++)
    {
         Console.Write($"{arr [i]} ");
    }
}




