﻿//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт максимальное.
Console.WriteLine("Введите первое чсло");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int m = Convert.ToInt32(Console.ReadLine());
int max = n;
int min = m;
if(n>max)max=n;
if(m>max)max=m;
Console.WriteLine("max=");
Console.WriteLine(max);
