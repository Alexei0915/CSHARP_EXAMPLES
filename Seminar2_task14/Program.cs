﻿//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
int b = 7;
int c = 23;

if (a % b ==0 & a % c ==0)
{
    Console.WriteLine("кратное");
    
} 
else
{
    Console.WriteLine("не кратно, остаток ");
}