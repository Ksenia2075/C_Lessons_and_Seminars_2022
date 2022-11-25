// Двумерный массив
// matrix[0, 0]  matrix[0, 1]  matrix[0, 2]
// matrix[1, 0]  matrix[1, 1]  matrix[1, 2]
Console.Clear();

void PrintArray(int[,] matr)
{
    for(int i=0; i<matr.GetLength(0); i++)
    {
        for(int j=0; j<matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for(int i=0; i<matr.GetLength(0); i++)
    {
        for(int j=0; j<matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}
int[,] matrix = new int[3, 4];
PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);
