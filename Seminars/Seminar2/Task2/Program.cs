// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого числа.

int DeleteDigit (int num)
{
    int sot = num/100;
    int ed = num%10;
    return sot*10+ed;
};

int randomNumber = new Random().Next(100,1000);
Console.WriteLine(randomNumber);
int result = DeleteDigit(randomNumber);
Console.WriteLine(result);
