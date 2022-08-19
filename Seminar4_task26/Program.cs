// Напишите программу которая принимает на вход число и выдает количество цифр в числе.
Console.WriteLine("Введите число");

int a =int.Parse(Console.ReadLine());

int count=1;

while (a != 0)
    {
    
        a = a / 10;
        count ++;
        
    }

Console.WriteLine($"Это число состоит из { count } цифр ");
