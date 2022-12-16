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
