//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа
int a = new Random().Next(100, 999);
Console.WriteLine(a);

int FirstDigit = a / 100;
int SecondDigit = a % 10;
Console.WriteLine(FirstDigit * 10 + SecondDigit);
