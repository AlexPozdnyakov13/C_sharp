//Задача 4: Напишите программу, которая принимает на вход 
//три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Input first number");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input third number");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b>max) 
{
    max=b;
}
if (c>max)
{
    max=c;
}
Console.WriteLine($"max = {max}");