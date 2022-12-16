// Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и
//  показывает наибольшую цифру числа.
//78 -> 8
//12-> 2
//85 -> 8

int MaxDigit (int num)
{
int a = num/10;
int b = num%10;
if (a>b)
{
    return a;
}
else return b;
};

int randomNumber = new Random().Next(10,100);
Console.WriteLine(randomNumber);
int result = MaxDigit(randomNumber);
Console.WriteLine(result);
