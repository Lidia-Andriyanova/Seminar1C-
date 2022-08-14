// Задайте двумерный массив. Найлите элементы, 
// у которых оба индекса четные, и замените 
// эти элементы на их квадраты.


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

void EditEvenElements(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i += 2)
    {
        for (int j = 0; j< matrix.GetLength(1); j += 2)
        {
            matrix[i, j]  = matrix[i, j] * matrix[i, j];
        }
    }
}


int[,] matrixResult = GetMatrix(3, 4, 1, 10);
PrintMatrix(matrixResult);
Console.WriteLine();

EditEvenElements(matrixResult);
PrintMatrix(matrixResult);


