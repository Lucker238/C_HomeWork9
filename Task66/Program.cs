// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int findSum(int m, int n)
{
    int max = m;
    int min = n;
    int sum = 0;

    if (n > m)
    {
        max = n;
        min = m;
    }
    if (min == max) sum += min;
    else sum += min + findSum(min+1, max);
    return sum;
}

System.Console.Write("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(findSum(M,N));