// Напишите программу,которая принимает на вход координаты двух точек и находит растояние между ними в 3D пространстве.
Console.WriteLine("введите А координаты");
int ax =int.Parse(Console.ReadLine());
int ay= int.Parse(Console.ReadLine());
int az= int.Parse(Console.ReadLine());
Console.WriteLine("введите B координаты");
int bx =int.Parse(Console.ReadLine());
int by= int.Parse(Console.ReadLine());
int bz= int.Parse(Console.ReadLine());
Console.WriteLine(ax-bx);
Console.WriteLine(ay-by);
Console.WriteLine(az-bz);

double AB = Math.Sqrt(Math.Pow (ax-bx,2) + Math.Pow (ay-by,2)+Math.Pow(az-bz,2) );

Console.WriteLine(AB);
