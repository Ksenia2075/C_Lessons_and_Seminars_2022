// 40. Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.Теорема о неравенстве 
//треугольника: каждая сторона треугольника меньше суммы двух других сторон.
Console.Clear();
Console.WriteLine($"Введите число а: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите число в: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите число с: ");
int c = Convert.ToInt32(Console.ReadLine());

void Triangle(int a, int b, int c)
{
    if(a<b+c && b<a+c && c<a+b) Console.WriteLine($"Yes");
    else Console.WriteLine($"No");
}

Triangle(a, b, c);

