Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
if((a * a == b)||(b * b == a ))
{
    Console.WriteLine("является");
}
else 
{
    Console.WriteLine("не является");
}