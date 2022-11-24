// Напишите программу, которая принимает на вход число и выдает количество цифр в числе.
Console.Clear();
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

int count = CountDig(num);

int CountDig(int number)
{
    int count = 0;
    while(number>0)
    {
        number=number/10;
        count++;
    }
    return count;
}

Console.WriteLine();
Console.WriteLine($"В числе {num} количество цифр - {count}");
