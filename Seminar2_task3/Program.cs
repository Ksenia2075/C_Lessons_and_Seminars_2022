// Программа проверяет пятизначное число на палиндромом.
Console.Clear();
Console.WriteLine("Введите число: "); 
int num = int.Parse(Console.ReadLine() ?? "0");  // ноль не вводим
int copy = num;
int reverse = 0;
while(copy > 0)
{
    int digit = copy % 10;
    reverse = reverse * 10;
    reverse = reverse + digit;
    copy = copy / 10;
}
if (num == reverse)
{
    Console.WriteLine("Palindrome");
}  
else
{
    Console.WriteLine("Not palindrome");
}   