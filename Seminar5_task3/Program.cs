// 33. Задайте массив. Напишите программу, которая определяет, присутствует ли 
// заданное число в массиве
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


int[] array = GetArray(12,-9,9);
Console.WriteLine();
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int a = 0;
foreach (int el in array)
{
    if (el==num)
    {
        a += 1;
    }
}
if (a>0) Console.WriteLine($"Да");
else Console.WriteLine($"Нет");
