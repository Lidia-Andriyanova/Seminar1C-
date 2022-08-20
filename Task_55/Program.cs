// Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.


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

int[,] ReplaceRowsCols(int[,] array) 
{
    int rowCount =  array.GetLength(0);
    int colCount =  array.GetLength(1);

    int[,] backArray = new int[colCount, rowCount];

    for (int i = 0; i < rowCount; i++)
    {
        for (int j = 0; j < colCount; j++)
        {
            backArray[j, i] = array[i, j];
        }
    }

    return backArray;
}

Console.Clear();
int[,] matrix = GetMatrix(5, 7, 1, 10);
PrintMatrix(matrix);

Console.WriteLine("Строки и столбцы поменены местами");
int[,] backArray = ReplaceRowsCols(matrix);
PrintMatrix(backArray);