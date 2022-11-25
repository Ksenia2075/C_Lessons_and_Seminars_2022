// Двумерный массив
// matrix[0, 0]  matrix[0, 1]  matrix[0, 2]
// matrix[1, 0]  matrix[1, 1]  matrix[1, 2]
Console.Clear();
int[,] matrix = new int[2, 3];

for(int i=0; i<2; i++)
{
    for(int j=0; j<3; j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
