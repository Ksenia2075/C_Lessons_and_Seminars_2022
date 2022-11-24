// Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N
Console.Clear();
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int i = GetCompos(num);
int GetCompos(int number)
{
    int i = 1;
    while(number>1)
    {
        i = i * number;
        number--;
    }
    return i;
}
Console.WriteLine($"Произведение от 1 до {num} = {i}");