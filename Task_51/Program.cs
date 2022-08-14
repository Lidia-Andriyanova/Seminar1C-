// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали
// (с индексами (0,0), (1,1) и т. д.)


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

int SumDiagonalElements(int[, ] matrix)
{
    int size = matrix.GetLength(0);
    if (matrix.GetLength(1) < size) size = matrix.GetLength(1);

    int sum = 0;
    for (int i = 0; i < size; i++)
    {
        sum += matrix[i, i];
    }
    return sum;
}


Console.Clear();
int[,] matrixResult = GetMatrix(3, 4, 1, 10);
PrintMatrix(matrixResult);

int diagSum = SumDiagonalElements(matrixResult);
Console.WriteLine($"Сумма эелементов на главной диагонали = {diagSum}");

