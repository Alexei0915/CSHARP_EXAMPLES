//Найдите произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент,второй и предпоследний и т.д.Результат запишите в новом массиве.
int [] array = {1,2,3,4,5};
int len = array.Length;
int index = 0;

Console.Write("Массив = ");
while (index < len)
{
    array [index] = new Random().Next(-10,10);
    Console.Write(array[index]);
    Console.Write(" ");
    index ++;
}
Console.WriteLine();
index= 0;
if (len % 2 == 0)
{
    while (index <len / 2)
    {
        Console.Write(array[index]*array[len- index-1]+ " ");
        index +=1;
    }
}
else
{
   while(index< len/2)
   {
    Console.Write(array[index]* array[len - index-1]+" ");
    index+=1;
   }
   Console.Write(array[index]);
}