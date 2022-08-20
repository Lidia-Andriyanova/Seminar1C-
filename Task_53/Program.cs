// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.

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
        if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j], 5}, ");
        else Console.Write($"{array[i, j], 5}]");
        }
        Console.WriteLine();
    }
}

void ReplaceRows(int[,] array) {

    int temp;
    int rowCount = array.GetLength(0);
    int colCount = array.GetLength(1);

    for (int i = 0; i < colCount; i++)
    {
        temp = array[0, i];
        array[0, i] = array[rowCount - 1, i];
        array[rowCount - 1, i] = temp;
    }
}

Console.Clear();
int[,] matrix = GetMatrix(5, 7, 1, 10);
PrintMatrix(matrix);

Console.WriteLine("Первая и последняя строки поменены местами");
ReplaceRows(matrix);
PrintMatrix(matrix);