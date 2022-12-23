// Задача 34: Задайте массив заполненный случайными положительными
//трёхзначными числами. Напишите программу, которая покажет
//количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2 

/* int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] myArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return myArray;
}

void ShowArray(int[] array)
{
    Console.WriteLine("Полученный массив ->:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int EvenCount(int[] array)
{
    int count = 0;
    for (int i=0; i<array.Length; i++)
    {
        if (array[i]%2==0) count++;
    }
    return count;
}

Console.WriteLine("Введите размер массива:");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимально возможное значение элемента массива:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимально возможное значение элемента массива:"); 
int max = Convert.ToInt32(Console.ReadLine());                                  

int[] newArray = CreateRandomArray(length,min,max);

ShowArray(newArray);
int Even = EvenCount (newArray);
Console.WriteLine($"Количество четных чисел: {Even}"); */

/* Задача 36: Задайте одномерный массив, заполненный случайными
 числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */

/* int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] myArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return myArray;
}

void ShowArray(int[] array)
{
    Console.WriteLine("Полученный массив ->:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int sumelements(int[]array)
{
    int sum=0;
    for (int i=1; i<array.Length; i+=2)
    {
        sum=sum+array[i];
    }
    return sum;
}
Console.WriteLine("Введите размер массива:");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимально возможное значение элемента массива:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимально возможное значение элемента массива:"); 
int max = Convert.ToInt32(Console.ReadLine());                                  

int[] newArray = CreateRandomArray(length,min,max);

ShowArray(newArray);
int sum1=sumelements(newArray);
Console.WriteLine($"Сумма элементов стоящих на нечетных позициях равна {sum1}"); */

/* Задача 38: Задайте массив вещественных чисел. Найдите разницу
 между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

double [] CreateRandomArray(int size, int minValue, int maxValue)
{
    double [] myArray = new double[size];
    for (int i = 0; i < size; i++)
    {
        myArray[i] = Convert.ToDouble(new Random().Next(minValue*10, maxValue*10)/10);
    }
    return myArray;
}

void ShowArray(double [] array)
{
    Console.WriteLine("Полученный массив ->:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double DiffMaxMin(double[] array)
{
    double diff=0;
    double max=array[0];
    double min=array[0];
    for (int i=0; i<array.Length; i++)
    {
        if (array[i]>max) max=array[i];
        if (array[i]<min) min=array[i];
    }
    diff=max-min;
    return diff;
}
Console.WriteLine("Введите размер массива:");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимально возможное значение элемента массива:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимально возможное значение элемента массива:"); 
int max = Convert.ToInt32(Console.ReadLine());                                  

double[] newArray = CreateRandomArray(length,min,max);

ShowArray(newArray);
double diff=DiffMaxMin(newArray);
Console.WriteLine($"Разница между максимальным и минимальным элементом равна {diff}");