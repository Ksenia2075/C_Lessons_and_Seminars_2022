// Напишите программу, которая принимает на вход число А и выдает сумму чисел от 1 до А

Console.Clear();
Console.Write("Введите число: ");
Console.WriteLine($"Сумма цифр = {GetSumNums(num)}");
//int num = int.Parse(Console.ReadLine());
//int num2 = int.Parse(Console.ReadLine());
//int sum1 = GetSumNums(num);
//int sum2 = GetSumNums(num2);
//Console.WriteLine(sum1);
//Console.WriteLine(sum2);

int GetSumNums(int number)
{
    int sum = 0;
    while(number>0)
    {
        Console.Write($"{sum} ");
        sum += number;
        number--;
    }
    Console.WriteLine(number);
    Console.WriteLine();
    return sum;
}
