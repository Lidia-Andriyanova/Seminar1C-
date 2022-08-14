// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

double[] ColAvg (int[,] matrix)
{
    int colCount = matrix.GetLength(1);
    int rowCount = matrix.GetLength(0);

    double [] avg = new double[colCount]; 

    double sum;
    for (int i = 0; i < colCount; i++)
    {
        sum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)    
        {
             sum +=  matrix[j, i];  
        }
        avg[i] = sum/rowCount;
        avg[i] = Math.Round(avg[i], 1);
    }
    return avg;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
     if (i == 0) Console.Write("[");
     if (i < array.Length - 1) Console.Write($"{array[i], 5}; ");
     else Console.Write($"{array[i], 5}] ");
    }
}

Console.Clear();
int[,] matrix = GetMatrix(5, 7, 1, 10);
PrintMatrix(matrix);

Console.WriteLine("Среднее арифметическое по столбцам:");
double[] colAvg = ColAvg(matrix);
PrintArray(colAvg);
Console.WriteLine();

