// Напишите программу, которая принимает 
//на вход число и проверяет, кратно ли оно одновременно 7 и 23.

void proverka (int num1)
{
    if (num1%7==0 && num1%23==0)
    {
        Console.WriteLine($"число {num1} кратно 7 и 23");
    }
    else
    {
        Console.WriteLine($"число {num1} не кратно 7 и 23");
    }
}
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
proverka (a);

