//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.


string findAllNumbers(int m, int n)
{
    int max = n;
    int min = m;
    if(m > n)
    {
        max = m;
        min = n;
    }
    string result = string.Empty;
    if (min == max)
    {
        result += Convert.ToString(max);
    }
    else
    {
        result += Convert.ToString(min) + ", " + findAllNumbers(min + 1, max);
    }
    return result;
}

System.Console.Write("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(findAllNumbers(M, N));