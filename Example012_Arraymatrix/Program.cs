// Двумерный массив
// table[0, 0]  table[0, 1]  table[0, 2]
// table[1, 0]  table[1, 1]  table[1, 2]
Console.Clear();
string[,] table = new string[2, 3];
table[0, 0] = "A";
table[0, 1] = "B";
table[0, 2] = "C";
table[1, 0] = "D";
table[1, 1] = "E";
table[1, 2] = "F";

for(int i=0; i<2; i++)
{
    for(int j=0; j<3; j++)
    {
        Console.Write($"{table[i, j]} ");
    }
    Console.WriteLine();
}

