//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

long akkerman(long n, long m)
{
  if (n == 0)
    return m + 1;
  else
    if (m == 0)
      return akkerman(n - 1, 1);
    else
      return akkerman(n - 1, akkerman(n, m - 1));
}


System.Console.Write("Введите M: ");
long M = Convert.ToInt64(Console.ReadLine());
System.Console.Write("Введите N: ");
long N = Convert.ToInt64(Console.ReadLine());

System.Console.WriteLine($"Функция Аккермана равна: {akkerman(M,N)}");