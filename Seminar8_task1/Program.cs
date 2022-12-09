//53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

// Console.Clear();
// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine());

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// Console.WriteLine();
// int[,] inarray = ChangeRows(array);
// PrintArray(inarray);

// //METHODS
// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m,n];
//     for(int i=0;i<m;i++)
//     {
//         for(int j=0;j<n;j++)
//         {
//             result[i,j] = new Random().Next(minValue, maxValue+1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] array)
// {
//     for(int i=0; i<array.GetLength(0); i++)
//     {
//         for(int j=0; j<array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] ChangeRows(int[,] array)
// {
//     int[,] result = new int[array.GetLength(0), array.GetLength(1)];
//     for(int i=0; i<array.GetLength(0); i++)
//     {
//         for(int j=0; j<array.GetLength(1); j++)
//         {
//             if (i == 0) result[i,j] = array[array.GetLength(0) - 1, j];
//             else if (i == array.GetLength(0) - 1) result[i,j] = array[0, j];
//             else result[i,j] = array[i,j];
//         }
//     }
//     return result;
// }

// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
if ( rows == columns) 
{
    int[,] newArray = ChangeArray(array);
    PrintArray(newArray);
}

else Console.WriteLine("Изменить массив невозможно");

// METHODS
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m,n];
    for(int i=0;i<m;i++)
    {
        for(int j=0;j<n;j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue+1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] ChangeArray(int[,] array)
{
    int[,] result = new int[array.GetLength(0), array.GetLength(1)];
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            result[i,j] = array[j,i];
        }
    }
    return result;
}

