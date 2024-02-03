// Задача 3: Задайте произвольный массив. 
//Выведете его элементы, начиная с конца. 
//Использовать рекурсию, не использовать циклы

using System;

class Program
{
    static void Main()
    {
        int[] array = { 7, 9, 3, 1, 5 };
        PrintArrayReversed(array, array.Length - 1);
    }

    static void PrintArrayReversed(int[] arr, int index)
    {
        if (index < 0)  
        {
            return;
        }
        else
        {
            Console.WriteLine(arr[index]); 
            PrintArrayReversed(arr, index - 1);
        }
    }
}

