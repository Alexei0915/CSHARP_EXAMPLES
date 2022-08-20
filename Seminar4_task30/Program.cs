// Напишите программу,которая выводит массив из 8 ми элементов
//заполненный нулями и единицами в случайном порядке.
int[] array = new int[8];
int i = 0;
while(i < array.Length )
{
    array[i]= new Random().Next(0, 2);
    Console.Write (array[i]);
    i++;
   
}


