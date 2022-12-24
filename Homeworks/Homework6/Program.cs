// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл
// пользователь.

/* 0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */

/* int AboveZero(int[] array)
{
    int count=0;
    for (int i=0; i<array.Length; i++) if (array[i]>0) count ++; 
    return count;
}

Console.WriteLine ("Введите ряд чисел через пробел");
string inputString = Convert.ToString(Console.ReadLine());
int[] array = inputString.Split(' ').Select(Int32.Parse).ToArray();

int count=AboveZero(array);
Console.WriteLine($"Кол-во положительных чисел => {count}"); */

/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

void Method (double b1, double k1, double b2, double k2)
{
    double x= (b2-b1)/(k1-k2);
    double y= k1*x+b1;
    if (k1==k2) Console.WriteLine ("Введите другие числа");
    else Console.WriteLine($"Координаты точки пересечения {x} и {y}");
}
Console.WriteLine("Введите значение b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k2");
double k2 = Convert.ToDouble(Console.ReadLine());
Method (b1,k1,b2,k2);