// Задача 24. Напишите программу,которая принимает на вход число (А)
// и выдает сумму чисел от 1 до А. 

Console.WriteLine("Введите число ");
int A = int.Parse(Console.ReadLine());
// int A;
// try
// {
//    A = int.Parse(Console.ReadLine());
// }
// catch (FormatException ex)
// {
//     Console.WriteLine("Format " + ex.Message);
//   return;
// }
// catch (OverflowException ex)
// {
//     Console.WriteLine("Overflow " + ex.Message);
//     return;
// }

int sum = 0;
for(int i = 1;i <=A; i++)
{
    sum = sum+=i;
}

Console.WriteLine($"{sum}");