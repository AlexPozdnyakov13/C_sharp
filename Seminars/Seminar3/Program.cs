//Задание1.  Напишите программу, которая принимает 
//на вход координаты точки (X и Y), причём X ≠ 0
// и Y ≠ 0 и выдаёт номер четверти плоскости,
// в которой находится эта точка.

/* int FindQuart (double x, double y)
{
    if(x>0 && y>0)
    return 1;
    if(x<0 && y>0)
    return 2;
    if(x<0 && y<0)
    return 3;
    if(x>0 && y<0)
    return 4;

    return 0;
}
Console.WriteLine("Input x");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input y");
double y = Convert.ToDouble(Console.ReadLine());
int result = FindQuart(x,y);
if (result ==0){
    Console.WriteLine("Point not found");
}
else {
    Console.WriteLine($"Point is on {result} quart");
} */

//Задача 2.Напишите программу, которая по заданному
// номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

/* void FindCoordinates(int quart)
{
    if (quart == 1)
    {
        Console.WriteLine("Диапазон координат x+ и y+");
    }
    if (quart == 2)
    {
    Console.WriteLine("Диапазон координат x- и y+");
    }
    if (quart == 3)
    {
    Console.WriteLine("Диапазон координат x- и y-");
    }
    if (quart == 4)
    {
    Console.WriteLine("Диапазон координат x+ и y-");
    }
    if (quart <1 || quart>4)
    {
    Console.WriteLine("Заданной четверти не существует");
    }
}
Console.WriteLine("Введите номер четверти");
int quart = Convert.ToInt32(Console.ReadLine());
FindCoordinates(quart); */

//Задача 3. Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между ними
// в 2D пространстве.

//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21
double N (double x1, double y1, double x2, double y2)
{
    double k1 = x1 - x2;
    double k2 = y1 - y2; 
    double g =Math.Round(Math.Sqrt(k1*k1+k2*k2),2);
 
return g ;
}
Console.WriteLine("Координаты x1:");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Координаты y1:");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Координаты x2:");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Координаты y2:");
double y2 = Convert.ToInt32(Console.ReadLine());

double result = N(x1, y1, x2, y2);
Console.WriteLine(result);

//Задача 4. Напишите программу которая принимает на
// вход число (N) и выдает на консоль квадраты чисел от 1 до N
/* void N(int number)
{
    
    for (int i = 1; i < number; i++)
    {
            Console.WriteLine (i*i);
    }
}

Console.WriteLine("Введите число:");
int x = Convert.ToInt32(Console.ReadLine());
N(x); */
