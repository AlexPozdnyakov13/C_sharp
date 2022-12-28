/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

/*  int[,] CreateRandom2DArray(int rows, int columns, int minValue, int maxValue)  
{                                                                           
  int[,] newArray = new int[rows, columns];  

  for (int i = 0; i < rows; i++)
  {
     for(int j = 0; j < columns; j++)
     {
       newArray[i,j] = new Random().Next(minValue,maxValue + 1);
     }
  }
  return newArray;    
}

void Show2DArray(int[,] array)
{
    for(int i = 0;i < array.GetLength(0) ;i++ ) 
    {
        for(int j = 0; j < array.GetLength(1); j++)  
        {
           Console.Write(array[i,j] + " ");
        }
        Console.WriteLine(); 
    }
}

int [,] Sorting(int [,] array)
{
    for (int i =0; i<array.GetLength(0); i++)
    
    for (int a=0; a<array.GetLength(1)-1; a++)

    for (int j=0; j<array.GetLength(1)-1; j++)
    {
        if (array[i,j]<array[i,j+1]) 
        {
            int temp = array[i,j];
            array[i,j]=array[i,j+1];
            array[i,j+1]=temp;
        }
    }
    return array;
}

Console.Write("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] newArray = CreateRandom2DArray(m,n,min,max);
Show2DArray(newArray);
Console.WriteLine();
newArray=Sorting(newArray);
Show2DArray(newArray); */

/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет
находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки
 с наименьшей суммой элементов: 1 строка */

/*  int[,] CreateRandom2DArray(int rows, int columns, int minValue, int maxValue)  
{                                                                           
  int[,] newArray = new int[rows, columns];  

  for (int i = 0; i < rows; i++)
  {
     for(int j = 0; j < columns; j++)
     {
       newArray[i,j] = new Random().Next(minValue,maxValue + 1);
     }
  }
  return newArray;    
}

void Show2DArray(int[,] array)
{
    for(int i = 0;i < array.GetLength(0) ;i++ ) 
    {
        for(int j = 0; j < array.GetLength(1); j++)  
        {
           Console.Write(array[i,j] + " ");
        }
        Console.WriteLine(); 
    }
}

void MinSumElements(int[,] array)
{
    int[] sum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumElements = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumElements = sumElements + array[i, j];
            sum[i] = sumElements;
        }
    }    
    int min = sum[0];
    int minSumLine = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (sum[i] < min)
        {
            min = sum[i];
            minSumLine = i;
        }
    }
    Console.WriteLine(minSumLine + " строка");
}

Console.Write("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] newArray = CreateRandom2DArray(m,n,min,max);
Show2DArray(newArray);
Console.WriteLine();
MinSumElements(newArray); */

/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

/* int[,] CreateRandom2DArray(int rows, int columns, int minValue, int maxValue)  
{                                                                           
  int[,] newArray = new int[rows, columns];  

  for (int i = 0; i < rows; i++)
  {
     for(int j = 0; j < columns; j++)
     {
       newArray[i,j] = new Random().Next(minValue,maxValue + 1);
     }
  }
  return newArray;    
}

void Show2DArray(int[,] array)
{
    for(int i = 0;i < array.GetLength(0) ;i++ ) 
    {
        for(int j = 0; j < array.GetLength(1); j++)  
        {
           Console.Write(array[i,j] + " ");
        }
        Console.WriteLine(); 
    }
}

int[,] MultipliedMatrix(int[,] array1, int[,] array2)
{
    int[,] MultMatrix = new int[array1.GetLength(0), array1.GetLength(1)];

    int i = 0;

    for (int a = 0; a < array1.GetLength(0); a++)
    {
        int y = 0;
        for (int b = 0; b < array1.GetLength(1); b++)
        {
            int x = 0;

            for (int j = 0; j < array1.GetLength(1); j++)

            {
                MultMatrix[a, b] = MultMatrix[a, b] + array1[i, j] * array2[x, y];
                x = x + 1;
            }
            y = y + 1;

        }
        i = i + 1;
    }
    return MultMatrix;

}
Console.Write("Введите количество строк 2-х матриц ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов 2-х матриц ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение каждой матрицы ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение каждой матрицы ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] newArray1 = CreateRandom2DArray(m,n,min,max);
int[,] newArray2 = CreateRandom2DArray(m,n,min,max);
Show2DArray(newArray1);
Console.WriteLine();
Show2DArray(newArray2);
Console.WriteLine();
int[,] MultMatrix= MultipliedMatrix (newArray1, newArray2);
Show2DArray(MultMatrix); */

/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
 которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

/* int[,,] CreateRandom3DArray(int rows, int columns, int depth, int minValue, int maxValue)  
{
    int[,,] newArray = new int[rows, columns, depth];
    for (int k = 0; k < depth; k++)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                newArray[i, j, k] = new Random().Next(minValue, maxValue + 1);
            }
        }
    }
    return newArray;
}

void Show3DArray(int[,,] array)
{
    int i1 = 0;
    int j1 = 0;
    int k1 = 0;
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                i1 = i;
                j1 = j;
                k1 = k;
                Console.Write($"{array[i, j, k]}({i1},{j1},{k1}) ");
            }
            Console.WriteLine();
        }
    }
}

Console.Write("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите глубину массива ");
int k = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение ");
int max = Convert.ToInt32(Console.ReadLine());

int[,,] newArray = CreateRandom3DArray(m,n,k,min,max);
Show3DArray(newArray); */

/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

int[,] Snake(int m, int n)
{
    int[,] newArray = new int[m, n];
    newArray[0, 0] = 0;
    for (int filledSize = 0; filledSize < m / 2; filledSize++)
    {
        for (int j = 1; j < n - filledSize; j++) newArray[filledSize, j] = newArray[filledSize, j - 1] + 1;
        for (int i = 1 + filledSize; i < m - filledSize; i++) newArray[i, m - 1 - filledSize] = newArray[i - 1, m - 1 - filledSize] + 1;
        for (int j = n - 2 - filledSize; j >= filledSize; j--) newArray[m - 1 - filledSize, j] = newArray[m - 1 - filledSize, j + 1] + 1;
        for (int i = m - 2 - filledSize; i > filledSize; i--) newArray[i, filledSize] = newArray[i + 1, filledSize] + 1;
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
Console.Write("Введите кол-во строк (желательно 4 :) ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов (желательно 4 :) ");
int n = Convert.ToInt32(Console.ReadLine());

Show2DArray(Snake(m, n));