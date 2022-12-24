// //Задача 1. Напишите программу, которая перевернёт одномерный
// массив (последний элемент будет на первом месте, 
//а первый - на последнем и т.д.)

//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]

/* 
int[] ReverseArray(int[] array)
{
    for(int i = 0; i < array.Length/2; i++) // 4 6 8 1
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
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
newArray = ReverseArray(newArray);
ShowArray(newArray); */

//Задача 2.Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник
// с сторонами такой длины.
//самое важное знать правило, какждая сторона должна быть
// меньше(строго) суммы двух других сторон

/* bool CheckTriangle (int x, int y, int z)
{
    if((x<y+z) && (y<x+z) && (z<x+y))
    {
        return true;
    }
    return false;
}

Console.WriteLine("Введите длину стороны a");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину стороны b");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину стороны c");
int z = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"CheckTriangle(x,y,z)");
bool res = CheckTriangle(x,y,z);
if(res == true)
{
    Console.WriteLine($"Треугольник со сторонами {x} {y} {z} может существовать ");
}
else
Console.WriteLine($"Треугольник со сторонами {x} {y} {z} не может существовать "); */

//Задача 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
//числа фибоначчи последовательность чисел в которой первые 2 числа это 0 и 1, а последубщие это сумма двух передыдущих
//[0, 1,2, 3, 5, 8, 13, ... ]

/* int[] Fib (int a, int b, int N)
{
    int [] Fib= new int [N];
    Fib[0]=a;
    Fib[1]=b;
    
    for (int i=2; i<N; i++)
    {
    Fib[i]=Fib[i-1]+Fib[i-2];
    }
    return Fib;

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

ShowArray(Fib(0,1,10)); */

//Задача 4. ****Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.

//45 -> 101101
//3 -> 11
//2 -> 10

string TwoDigits (int num)
{
    string result = string.Empty;
 
    while (num >0)
    {
       result=num%2 + result;
       num=num/2;
    }
    
    return result;

}
Console.WriteLine (TwoDigits(20));