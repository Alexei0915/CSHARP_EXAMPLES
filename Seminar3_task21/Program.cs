//Напишите программу,которая принимает на вход координаты двух точек и находит растояние между ними в 2D пространстве.
Console.WriteLine("введите А координаты");
int ax =int.Parse(Console.ReadLine());
int ay= int.Parse(Console.ReadLine());
Console.WriteLine("введите B координаты");
int bx =int.Parse(Console.ReadLine());
int by= int.Parse(Console.ReadLine());

Console.WriteLine(ax-bx);
Console.WriteLine(ay-by);

double AB = Math.Sqrt(Math.Pow (ax-bx,2) + Math.Pow (ay-by,2));

Console.WriteLine(AB);
