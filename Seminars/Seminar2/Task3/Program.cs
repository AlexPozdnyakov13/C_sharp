// Напишите программу, которая будет принимать на вход
// два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.

//34, 5 -> не кратно, остаток 4
//16, 4  -> кратно
void kratnost (int num1, int num2)
{
if (num1%num2==0)
{
    Console.WriteLine($"число {num2} кратно {num1}");
}
else {
    int num3 = num1%num2;
    Console.WriteLine($"не кратно, остаток от деления {num3}");
}
};
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
kratnost (a,b);
