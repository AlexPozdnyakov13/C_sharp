/* /* Задача 19

Напишите программу, которая принимает на вход пятизначное число
и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
 */
/* void pal(int num)
{
    int x=num/10000;
    int y=num%10;
    int c= num/1000%10;
    int d=num/10%10;
    if (x==y&&c==d)
    {
        Console.WriteLine("Это число - палиндром");
    }
    else
    {
        Console.WriteLine("Это число - НЕ палиндром");
    }
}

Console.WriteLine("Введите 5-значное число");
int n = Convert.ToInt32(Console.ReadLine());
pal(n); */

/* Задача 21 */

/* Напишите программу, которая принимает на вход координаты
двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 */

/* double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double g=Math.Round(Math.Sqrt(Math.Pow((x1-x2),2)+Math.Pow(y1-y2,2)+Math.Pow(z1-z2,2)),2);
    return g;
}
Console.WriteLine("Введите координату х первой точки");
int a1 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y первой точки");
int b1 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z первой точки");
int c1 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату х второй точки");
int a2 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y второй точки");
int b2 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z второй точки");
int c2 =Convert.ToInt32(Console.ReadLine());
double result=Distance(a1,b1,c1,a2,b2,c2);
Console.WriteLine($"Расстояние между этими точками равно {result}"); */

/* Задача 23

Напишите программу, которая принимает на вход число (N)
 и выдаёт таблицу кубов чисел от 1 до N.
 */
/* 3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */
void cube (int n)
{
    for (int i=1; i<n+1; i++)
    {
        double result=Convert.ToDouble(Math.Pow(i,3));
        Console.Write($"{result}, ");
    }
}
Console.WriteLine("Введите число");
int b=Convert.ToInt32(Console.ReadLine());
cube(b);