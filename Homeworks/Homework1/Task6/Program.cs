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
