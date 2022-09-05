// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

int m = InputNum("Введите m: ");
int n = InputNum("Введите n: ");

int FAkkerman = AkF(m, n);

Console.Write($"Функция Аккермана = {FAkkerman} ");

int AkF(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return AkF(m - 1, 1);
  else return AkF(m - 1, AkF(m, n - 1));
}

int InputNum(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}