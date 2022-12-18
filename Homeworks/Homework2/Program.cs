/* Задача 10: Напишите программу, которая принимает
на вход трёхзначное число и на выходе показывает вторую
цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

/* int FindSecondDigit(int n)
{
    int x=n%10;
    int y=(n-x)/10%10;
    return y;
}

int randomNumber = new Random().Next(100,1000);
Console.WriteLine(randomNumber);
int result = FindSecondDigit(randomNumber);
Console.WriteLine(result); */

/* Задача 13: Напишите программу, которая выводит
 третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */


/* void findThirdDigit(int n)
{
    if (n < 100)
    {
        Console.WriteLine("No third digit");
    }
    else 
    {
        int index = 0;
        while (index < 20)
            {   
                if (n>999)
                {
                    int z = n % 10;
                    n = (n -z)/ 10; 
                }
            index++;
            }
        
        int y = n % 10;
        Console.WriteLine($"Third digit is {y}");
        
    }
   
}; 

int randomNumber = new Random().Next(1,1000000000);
Console.WriteLine(randomNumber);
findThirdDigit(randomNumber); */

/* Задача 15: Напишите программу, которая принимает на вход
цифру, обозначающую день недели, и проверяет,
является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */ 

void WeekDay (int d)
{
    if (d==6||d==7)
    {
        Console.WriteLine("выходной");
    }
    else
    {
        Console.WriteLine("рабочий день");
    }
}
Console.WriteLine("введите день недели в виде цифры от 1 до 7");
int y = Convert.ToInt32(Console.ReadLine());
WeekDay(y);