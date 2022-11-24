// 35. Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99]. 
Console.Clear();
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for(int i=0; i<size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);
        Console.Write($"{res[i]} ");
    }
    return res;
}


int[] array = GetArray(123,0,1000);
Console.WriteLine();
int count = 0;

foreach (int el in array)
{
    if (el>9 && el<100) count++;
}
Console.WriteLine($"{count}");

