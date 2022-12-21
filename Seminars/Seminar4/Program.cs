//Задача 1. Напишите программу, которая принимает на вход
/*  число (А) и выдаёт сумму чисел от 1 до А. */

/* int FindSum (int num)
{
    int sum = 0;
    for(int current= 1; current<=num;current++)
    {
        sum += current;
    }
    return sum;
}

Console.WriteLine("Input A:");
int a = Convert.ToInt32(Console.ReadLine());
int result = FindSum(a);
Console.WriteLine(result); */

//Задача 2.Напишите программу, которая принимает на вход число
// и выдаёт количество цифр в числе.

//456 -> 3
//78 -> 2
//89126 -> 5

/* int Number (int num)
{
    int count = 0;
    while (num != 0)
    {
      num /= 10;
      count++;
    }
    return count;
}

Console.WriteLine("Input A:");
int a = Convert.ToInt32(Console.ReadLine());
int result = Number(a);
Console.WriteLine(result); */



//Задача 3. Напишите программу, которая принимает на вход число N
// и выдаёт произведение чисел от 1 до N.

//4  -> 24
//5  -> 120

/* int Factorial (int num)
{
    int fact = 1;
    for(int current = 1; current<=num;current++)
    {
        fact = fact * current;
    }
    return fact;
}

Console.WriteLine("Input A:");
int a = Convert.ToInt32(Console.ReadLine());
int result = Factorial(a);
Console.WriteLine(result); */

//Задача 4. Напишите программу, которая выводит массив из 8
// элементов, заполненный нулями и единицами в случайном порядке.

// [1,0,1,1,0,1,0,0]

int[] CreateRandomArray (int size,int minValue, int maxValue)
{
    int[] myArray = new int[size];
    for(int i=0;i<size;i++)
    {
        myArray[i] = new Random().Next(minValue,maxValue+1);
    }
    return myArray;
}

void ShowArray (int[] array)
{
    Console.WriteLine("Полученный массив ->:");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }
    Console.WriteLine();
}
Console.WriteLine("Введите размер массива:");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимально возможное значение элемента массива:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимально возможное значение элемента массива:");
int max = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(lenght,min,max);
// ShowArray(newArray);

ShowArray(CreateRandomArray(length,min,max));


