/* Задача 25: Напишите цикл, который принимает на вход 
два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 */

/* int Stepen(int a, int b)
{
    int result = 1;
    for (int i=1; i <= b; i++)
        {
            result=result*a;
        } 
    return result;
}

Console.WriteLine("Введите число A");
int x=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень B");
int y=Convert.ToInt32(Console.ReadLine());
int result=Stepen(x,y);
Console.WriteLine(result); */

/* Задача 27: Напишите программу, которая принимает
 на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */

int SumOfDigits(int num)
{
    int i=1;
    int sum=0;
    while (num !=0)
    {
        sum=sum+num%10;
        num=num/10;
        i++;
    }
    return sum;
}

Console.WriteLine("Введите число");
int x=Convert.ToInt32(Console.ReadLine());
int result=SumOfDigits(x);
Console.WriteLine($"Сумма цифр равна {result}");