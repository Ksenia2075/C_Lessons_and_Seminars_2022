//42. Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3 -> 11
//2 -> 10

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

string GetNumber(int num)
{
    string res = "";
    while (num > 0)
    {
        int x = num % 2;
        res = x + res;
        num = num / 2;
    }
    return res;
}

Console.WriteLine(GetNumber(num));

//Console.Clear();

//int[] DecimalToBinary(int number)
//{
//    int[] bin = new int[8];
//    for(int i=0; i<8; i++)
//    {
//        if(number%2 == 1) bin[i] = 1;
//        else bin[i] = 0;
//        number = number/2;
//    }
//    return bin;
//}

//void ReversArray1(int[] inArray)
//{
//    for(int i=0; i<inArray.Length/2; i++)
//    {
//        int k = inArray[i];
//        inArray[i] = inArray[inArray.Length-1-i];
//        inArray[inArray.Length-1-i] = k;
//    }
//}

//void PrintArray(int[] arr)
//{
//    for(int i=0; i<arr.Length;i++)
//    {
//        Console.Write($"{arr[i]} ");
//    }
//}

//Console.WriteLine("Введите число: ");
//int num = Convert.ToInt32(Console.ReadLine());
//int[] array = DecimalToBinary(num);
//ReversArray(array);
//PrintArray(array);
