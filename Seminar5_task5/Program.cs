// 37. Найдите произведение пар чисел в одномерном массиве.Парой считаем первый 
// и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
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


int[] array = GetArray(10,1,10);
Console.WriteLine();
int massLength = array.Length / 2+1;
int[] mass = new int[massLength];
Console.WriteLine();

for (int i=0; i<massLength; i++)
{
    mass[i] = array[i]*array[array.Length -1 -i];
    Console.Write($"{mass[i]} ");
}

