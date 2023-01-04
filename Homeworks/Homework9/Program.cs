/* Задача 64: Задайте значение N. Напишите программу, которая выведет
 все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

/* void PrintNumbers (int num)
{
    if (num>=1)
    {
        Console.Write(num+" ");
        PrintNumbers(num-1);
    }
}
Console.WriteLine("Введите число");
int n=Convert.ToInt32(Console.ReadLine());
PrintNumbers(n); */

/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

/* int FindSum(int m, int n)
{
    if (m != n)
    {
        int sum = 0;
        if (m > n)
        {
            sum = m + FindSum(m - 1, n);
        }
        else if (n > m)
        {
            sum = n + FindSum(m, n - 1);
        }
        return sum;
    }
    else return m;
}
Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
int sum = FindSum(m, n);
Console.WriteLine(sum); */

/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
 Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

int ack (int m, int n)
{
    if (m==0) return n+1;
    else if (n==0) return ack(m-1,1);
    else return ack(m - 1, ack (m, n - 1));
}
Console.WriteLine("Введите число m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n");
int n = Convert.ToInt32(Console.ReadLine());
int result = ack(m,n);
Console.WriteLine(result);
