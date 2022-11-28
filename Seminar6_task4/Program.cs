// 44. Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Clear();
int[] Fibonacci(int num)
{
    int[] fibo = new int[num];
    fibo[0] = 0;
    fibo[1] = 1;
for(int i=2; i<num; i++)
    fibo[i] = fibo[i-1] + fibo[i-2];
    return fibo;
}
void PrintArray(int[] arr)
{
    for(int i=0; i<arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");
int[] fibonac = new int[number];
fibonac = Fibonacci(number);
PrintArray(fibonac);
