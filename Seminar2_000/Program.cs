int a = new Random().Next(10, 100);

Console.WriteLine("Случайное число от 10 до 99: "+a);

int FirstDigit = a / 10;
int SecondDigit = a % 10;

if(FirstDigit>SecondDigit)
{
    Console.WriteLine("Наибольшая цифра: "+FirstDigit);
}
else
{
    Console.WriteLine("Наибольшая цифра: " + SecondDigit);
}