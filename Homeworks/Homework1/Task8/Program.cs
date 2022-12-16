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
