﻿// 39. Напишите программу, которая перевернет одномерный массив (последний элемент будет
// на первом месте, а первый - на последнем)
Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for(int i=0; i<size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}

void ReversArray1(int[] inArray)
{
    for(int i=0; i<inArray.Length/2; i++)
    {
        int k = inArray[i];
        inArray[i] = inArray[inArray.Length-1-i];
        inArray[inArray.Length-1-i] = k;
    }
}

void PrintArray(int[] arr)
{
    for(int i=0; i<arr.Length;i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int[] ReversArray2(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for(int i=0; i<inArray.Length;i++)
    {
        result[i] = inArray[inArray.Length-1-i];
    }
    return result;
}

int[] array = GetArray(10,0,10);
PrintArray(array);
Console.WriteLine();
//ReversArray1(array);
//PrintArray(array);
Console.WriteLine();
int[] reversArray = ReversArray2(array);
PrintArray(reversArray);
