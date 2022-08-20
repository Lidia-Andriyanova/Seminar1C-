// Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.

int [,] GetMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j< matrix.GetLength(1); j++)
        {
            matrix[i, j]  = rnd.Next(min, max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        if (j == 0) Console.Write("[");
        if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j], 3}, ");
        else Console.Write($"{array[i, j], 3}]");
        }
        Console.WriteLine();
    }
}


void SortRowMatrix(int[,] matrix)
{
    int rowCount = matrix.GetLength(0);
    int colCount = matrix.GetLength(1);
    int maxIndex = 0;
    int temp = 0;

    for (int i = 0; i < rowCount; i++)
    {
        for (int j = 0; j < colCount - 1; j++)
        {
            maxIndex = j;
            for (int k = j + 1; k < colCount; k++)
            {
                if (matrix[i, k] > matrix[i, maxIndex])
                    maxIndex = k;
            }

            temp = matrix[i, j];
            matrix[i, j] = matrix[i, maxIndex];
            matrix[i, maxIndex] = temp;
        }
    }
}


Console.Clear();
int[,] matrix = GetMatrix(5, 7, -10, 10);
PrintMatrix(matrix);

Console.WriteLine("Отсортированные по убыванию строки");
SortRowMatrix(matrix);
PrintMatrix(matrix);