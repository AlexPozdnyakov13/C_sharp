// Задача 3: Напишите программу, которая принимает 
//на вход два числа и проверяет, является ли одно число 
//квадратом другого.

void quad(int a, int b)
{
    if (a==b*b)
    {
        Console.WriteLine($"{a} квадрат {b}");
    }
    else
    {
        Console.WriteLine($"{a} не является квадратом {b}");
    }
};
Console.WriteLine("Ведите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
quad (num1,num2);