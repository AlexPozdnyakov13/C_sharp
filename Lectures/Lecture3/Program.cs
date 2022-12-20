//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

/* string Replace(string text, char oldValue, char newValue)
{
string result = String.Empty;
int length = text.Length;
for (int i = 0; i < length; i++)
{
if(text[i] ==oldValue) result = result + $"{newValue}";
else result = result + $"{text[i]}";
}
return result;
}
string text = "— Я думаю, — сказал князь, улыбаясь, — что,";

string newtext = Replace(text, 'к', 'К');
Console.WriteLine(newtext); */

/* Задача 25. Упорядочение массива (сортировка методом выбора, минмакс) */

/* int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}
void selectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i+1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
selectionSort(arr);
PrintArray(arr); */

/* Задача 26. Упорядочение массива (сортировка методом выбора, 
минмакс) ОТ БОЛЬШЕГО К МЕНЬШЕМУ*/

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}
void selectionSort(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        int maxPosition = i;
        for (int j = i+1; j < array.Length; j++)
        {
            if(array[j] > array[maxPosition]) maxPosition = j;
        }
        
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}
PrintArray(arr);
selectionSort(arr);
PrintArray(arr);
