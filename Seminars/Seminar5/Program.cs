//Задача 1. Задайте массив из 12 элементов, заполненный случайными
// числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна -20.

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

void FindMinMAxSum (int[] array)
{
    int sumPositive = 0;
    int sumNegative = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) sumPositive += array[i];
        else
        sumNegative += array[i];
    }
    Console.WriteLine($"Сумма положительных элементов {sumPositive}, а отрицательных {sumNegative}");
}
Console.WriteLine("Введите размер массива:");
int lenght = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимально возможное значение элемента массива:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимально возможное значение элемента массива:"); 
int max = Convert.ToInt32(Console.ReadLine());                                  

int[] newArray = CreateRandomArray(lenght,min,max);

ShowArray(newArray);
FindMinMAxSum(newArray); */

//Задача 2. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

//[-4, -8, 8, 2] -> [4, 8, -8, -2]

/* int[] ChangeElemets (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
    return array;
}


Console.WriteLine("Введите размер массива:");
int lenght = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимально возможное значение элемента массива:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимально возможное значение элемента массива:"); 
int max = Convert.ToInt32(Console.ReadLine());                                  

int[] newArray = CreateRandomArray(lenght,min,max);

ShowArray(newArray);
newArray = ChangeElemets(newArray);
ShowArray(newArray); */

//Задача 3.Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//3; массив [6, 7, 19, 345, 3] -> да

/* bool FindNumber (int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        
        if (array[i] == num)
        return true;
    }
    Console.WriteLine();
    return false;
}

int[] array1 = new int[] { 1,5,9,6 };
int x = 12;

Console.WriteLine($"Искомое в массиве число -> {x}");

ShowArray(array1);
if (FindNumber(array1, x))
    {
    Console.WriteLine("Данное число присутствует в массиве");
    }
else
    {
    Console.WriteLine("Данное число не присутствует в массиве");
    } */

//Задача 4.****Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
//значения которых лежат в отрезке [10,99].
//*Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*

void Sum (int[] array, int LowerBorder, int TopBorder)
{
    int Count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] >= LowerBorder && array [i] <= TopBorder) 
        Count++;
    }
    Console.WriteLine($"Количество элементов между {LowerBorder} и {TopBorder} равно {Count}");
}

int length = 123;

Console.WriteLine("Введите минимально возможное значение элемента массива:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимально возможное значение элемента массива:"); 
int max = Convert.ToInt32(Console.ReadLine());                                  

Console.WriteLine("Введите нижнюю границу интервала");
int bot = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите верхнюю границу интервала:"); 
int top = Convert.ToInt32(Console.ReadLine());    

int[] newArray = CreateRandomArray(lenght,min,max);

ShowArray(newArray);
Sum(newArray,bot,top);
//Доп задача. Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент,
 //второй и предпоследний и т.д. Результат запишите в новом массиве.

//[1 2 3 4 5] -> 5 8 3

//[6 7 3 6] -> 36 21

void Sum (int[] array)
{
    int product = 1;
    for(int i = 0; i < (array.Length-1)/2+1; i++)
    {
        product = array[i] * array [array.Length - 1 - i];
        Console.Write(product+" ");
    }
}

Console.WriteLine("Введите размер массива:");
int lenght = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимально возможное значение элемента массива:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимально возможное значение элемента массива:"); 
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(lenght, min, max);
ShowArray(newArray);
Sum(newArray);
