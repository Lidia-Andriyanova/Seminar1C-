//Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

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

int[,] MatrixComposition(int[,] matrix1, int[,] matrix2)
{
    int m = matrix1.GetLength(0);
    int n = matrix1.GetLength(1);

    int n2 = matrix2.GetLength(0);
    int q =  matrix2.GetLength(1);

    int[,] resultMatrix;

    if (n == n2)
    {
        resultMatrix = new int[m, q];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < q; j++)
            {
                resultMatrix[i, j] = 0;
                for (int k = 0; k < n; k++)
                {
                    resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];     
                }    
            }
        }
    }
    else
    {
        resultMatrix = new int[1, 1];
    }
    return resultMatrix;
}

Console.Clear();
Console.WriteLine("Первая матрица:");
int[,] matrix1 = GetMatrix(2, 2, 1, 10);
PrintMatrix(matrix1);

Console.WriteLine("Вторая матрица:");
int[,] matrix2 = GetMatrix(2, 2, 1, 10);
PrintMatrix(matrix2);

int[,] composeMatrix = MatrixComposition(matrix1, matrix2);

if (composeMatrix.GetLength(0) == 1 && composeMatrix.GetLength(1) == 1) 
    Console.WriteLine($"Число столбцов первой матрицы = {matrix1.GetLength(1)} не совпадает с числом строк второй матрицы = {matrix2.GetLength(0)}");
else
{
    Console.WriteLine("Произведение матриц:");    
    PrintMatrix(composeMatrix);
}

