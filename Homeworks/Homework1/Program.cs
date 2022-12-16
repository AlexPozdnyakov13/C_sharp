//Задача 2. На вход получаем 2 числа и нужно выдать какое число большее,
//а какое меньшее
Console.WriteLine("Input first number");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number");
int y = Convert.ToInt32(Console.ReadLine());
if (x>y) 
{
    Console.WriteLine($"{x} is bigger than {y}");
}
else
{
    Console.WriteLine($"{y} is bigger than {x}");
}

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
//Задача 6: Напишите программу, которая на вход принимает
// число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Input number");
int d = Convert.ToInt32(Console.ReadLine());
int e = d % 2;
if (e == 0)
{
    Console.WriteLine($"{d} - число четное");
}
else
{
    Console.WriteLine($"{d} - число нечетное");
};

//Задача 8: Напишите программу, которая на вход 
//принимает число (N), а на выходе показывает все
 //чётные числа от 1 до N.
 Console.WriteLine("Input number");
 int n = Convert.ToInt32(Console.ReadLine());
 int o =2;
 if (n < 2)
 {
    Console.WriteLine("нет четных чисел");   
 };
 if (n>=2)
 {
    while (o<n+1)
    {
        Console.Write($"{o}, ");
        o=o+2; 
    }
 };