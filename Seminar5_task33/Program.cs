// Задайте массив.Напишите программу,которая определяет,присутствует ли заданное число в массиве.
void FillArray(int [] arr)
{
    int length= arr.Length;
    for (int i= 0;i <length;i++)
    {
        arr[i] = new Random().Next(-100,100);
    }
}
void PrintArray(int [] arr)
{
    int length= arr.Length;
    for (int i= 0;i < length ;i++)
    {
         Console.Write($"{arr [i]} ");
    }
}
int[] array = new int[5];

FillArray(array);
PrintArray(array);

Console.WriteLine("Введите число");
int a =int.Parse(Console.ReadLine());

int var = 0;
for (int i = 0; i < array.Length; i++)
{
    if (a == array[i])
    {
      Console.Write($"число присутствует");
      var++;//если число нашлось прибавляем 
      break;
    }
}
if(var ==0)
{
    Console.Write($"число не присутствует");
}
// Заготовка ввода массива.
// void FillArray(int [] arr)
// {
//     int length= arr.Length;
//     for (int i= 0;i <length;i++)
//     {
//         arr[i] = new Random().Next(-100,100);
//     }
// }
// void PrintArray(int [] arr)
// {
//     int length= arr.Length;
//     for (int i= 0;i < length ;i++)
//     {
//          Console.Write($"{arr [i]} ");
//     }
// }
// int[] array = new int[5];

// FillArray(array);
// PrintArray(array);