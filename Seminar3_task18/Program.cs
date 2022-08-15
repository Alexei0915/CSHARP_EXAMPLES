// // Напишите программу,которая по заданному номеру четверти,показывет диапазон возможных координат точек в этой четверти ( х и у).
// Console.WriteLine("Введите номер четверти x y координат(от 1 до 4)");
// int n = Convert.ToInt32(Console.ReadLine());
// if (n <= 4)
// {
//     if(n <= 2 )
//     {
//        if(n < 2)
//        {
//            Console.WriteLine("x > 0,y > 0");
//        }
//        else
//        { 
//              Console.WriteLine("x < 0, y > 0");
//        }
//     } 
//     else if (n > 3)
//     {
//      Console.WriteLine("x > 0, y <0 ");
//     }
//     else 
//     {
//      Console.WriteLine("x < 0,y < 0 ");
//     }
// }

//Либо с использованием try/catch.
Console.WriteLine ("Введите номер четверти от 1 до 4");
int count = 0;
while(count<5){
try
    {
        int x = int.Parse(Console.ReadLine());
        string [] q1={"x > 0 и y > 0", "x < 0 и y > 0", "x < 0 и y < 0", "x > 0 и y < 0 "};
        Console.WriteLine("диапазон значений для четверти"+ x +"равен:"+ q1[x - 1]);
        break;
    }
catch
    {
        Console.WriteLine ("введи от 1 до 4");
        Console.WriteLine();
        count++;
        if(count ==5)
          {
            Console.WriteLine("конец попыток");
          }
    }
}