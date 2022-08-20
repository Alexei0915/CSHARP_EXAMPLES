// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("введите элементы массива");
int num = int.Parse(Console.ReadLine());
int[] array = new int [8];
int len = array.Length;
int index = 0;
while(index < len)
{
    array[index] = int.Parse(Console.ReadLine());
    index++;
} 
for (int i = 0; i < len; i++)
{
    Console.Write(array[i]);
} 

Console.Write(Convert.ToInt32 ('1'));