/* Задача 47. Задайте двумерный массив размером m*n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9 */

/* double[,] Create2DRandomArray(int m, int n, int minValue, int maxValue)
{
    double[,] newArray = new double[m, n];
    for (int i = 0; i < newArray.GetLength(0); i++)
        for (int j = 0; j < newArray.GetLength(1); j++)
            newArray[i, j] = Math.Round(new Random().Next(minValue, maxValue + 1) + new Random().NextDouble(), 2);
    return newArray;
}

 void Show2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

        { Console.Write(array[i, j] + " "); }

        Console.WriteLine();
    }
}
Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение");
int maxValue = Convert.ToInt32(Console.ReadLine());

double[,] newArray = Create2DRandomArray(m, n, minValue, maxValue);
Show2DArray(newArray); */

/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет */

/* int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newArray;
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
void ShowElement(int[,] array, int i, int j)
{
    if (i < array.GetLength(0) && j < array.GetLength(1) && i >= 0 && j >= 0)
    {
        Console.WriteLine(array[i, j]);
    }
    else Console.WriteLine("Такого элемента в массиве нет");
}


Console.Write("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DRandomArray(m, n, min, max);
Show2DArray(myArray);

Console.Write("Введите позицию строки ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию столбца ");
int j = Convert.ToInt32(Console.ReadLine());
ShowElement(myArray, i, j); */

/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов
в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newArray;
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void Average(int[,] array)
{

    int m = array.GetLength(0);
    double avg = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < m; i++)
        {
            sum = sum + array[i, j];
        }
        avg = sum / m;
        Console.Write(avg + "; ");
    }
}
Console.Write("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DRandomArray(m, n, min, max);
Show2DArray(myArray);
Console.WriteLine("Среднее арифметическое элементов в каждом столбце:");
Average(myArray);
