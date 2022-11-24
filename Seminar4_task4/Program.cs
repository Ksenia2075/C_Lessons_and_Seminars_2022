// Напишите программу, которая выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
Console.Clear();

void FillArray(int[] arr)
{
    int length = arr.Length;
    for(int i = 0; i<length; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
}

void PrintArray(int[] arr)
{
    int length = arr.Length;
    for (int i = 0; i<length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int[] arr = new int[8];
FillArray(arr);
PrintArray(arr);
Console.WriteLine();