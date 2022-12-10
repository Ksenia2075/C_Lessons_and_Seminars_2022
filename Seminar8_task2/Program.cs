// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.
// 25 мин
// Набор данных Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 } 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

// ВАРИАНТ 1
// Console.Clear();
// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine());
// Console.Write("Введите минимальное значение массива: ");
// int minValue = int.Parse(Console.ReadLine());
// Console.Write("Введите максимальное значение массива: ");
// int maxValue = int.Parse(Console.ReadLine());

// int[,] array = GetArray(rows, columns, minValue, maxValue);     // получаем массив через метод
// PrintArray(array);                                              // печатаем исходный массив
// Console.WriteLine();
// int[] newArray = CountNums(array, maxValue);             // через метод считаем  кол-во элементов
// for (int i = 0; i < newArray.Length; i++)
// {
//     if(newArray[i] != 0) Console.WriteLine($"Элемент {i} встречается {newArray[i]} раз(a) ");
// }


// // METHODS
// int[,] GetArray(int m, int n, int minValue, int maxValue)     // метод. получаем двумерный массив
// {
//     int[,] result = new int[m,n];
//     for(int i=0;i<m;i++)
//     {
//         for(int j=0;j<n;j++)
//         {
//             result[i,j] = new Random().Next(minValue, maxValue);   // заполненный случайными числами
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


// int[] CountNums(int[,] array, int maxValue)
// {
//     int[] result = new int[maxValue];
//     for (int index = 0; index < maxValue; index++)
//     {
//         int count = 0;
//         for(int i=0; i<array.GetLength(0); i++)
//         {
//             for(int j=0; j<array.GetLength(1); j++)
//             {
//                 if (array[i,j] == index) count++;
//             }
//         }
//         result[index] = count;
//     }
//     return result;
// }


// ВАРИАНТ 2
Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int minValue = int.Parse(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int maxValue = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, minValue, maxValue);     // получаем массив через метод
PrintArray(array);                                              // печатаем исходный массив
Console.WriteLine();
int[] rowAr = GetRowArray(array);
SortArray(rowAr);
Console.WriteLine(String.Join(" ",rowAr));
PrintData(rowAr);

// METHODS
int[,] GetArray(int m, int n, int minValue, int maxValue)     // метод. получаем двумерный массив
{
    int[,] result = new int[m,n];
    for(int i=0;i<m;i++)
    {
        for(int j=0;j<n;j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue);   // заполненный случайными числами
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


int[] GetRowArray(int[,] inArray)
{
    int[] result = new int[inArray.GetLength(0)*inArray.GetLength(1)];
    int index = 0;
    for(int i=0; i<inArray.GetLength(0); i++)
    {
        for(int j=0; j<inArray.GetLength(1); j++)
        {
            result[index] = inArray[i,j];
            index++;
        }
    }
    return result;
}


void SortArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        for (int j = 0; j < inArray.Length; j++)
        {
            if (inArray[i] > inArray[j])
            {
                int k = inArray[i];
                inArray[i] = inArray[j];
                inArray[j] = k;
            }
        }
    }
}


void PrintData(int[] inArray)
{
    int el = inArray[0];
    int count = 1;
    for (int i = 1; i < inArray.Length; i++)
    {
        if (inArray[i] != el)
        {
            Console.WriteLine($"{el} встречается {count} ");
            el=inArray[i];
            count=1;
        }
        else 
        {
            count++;
        }
    }
    Console.WriteLine($"{el} встречается {count} ");
}







// Задача 59: Задайтедвумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7




// Задача 61: Вывести первые N строк треугольника
// Паскаля. Сделать вывод в виде равнобедренного
// треугольника
