// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.

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

int[] FirstMinElem(int[,] matrix)
{
    int min = matrix[0, 0];
    int[] point = new int[3] {0, 0, min};

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                point[0] = i;
                point[1] = j;
                point[2] = min;
            }
        }
    }

    return point;
}

int[,] DeleteRowCount(int[,] matrix, int[] point)
{
    int rowCount = matrix.GetLength(0);
    int colCount = matrix.GetLength(1);

    int[,] delMatrix = new int[rowCount - 1, colCount - 1];  

    int row = 0;
    int col = 0;

    for (int i = 0; i < rowCount; i++)
    {
        for (int j = 0; j < colCount; j++)
        {
            if (i != point[0] || j != point[1]) 
            {
                if (i < point[0]) row = i;
                else row = i + 1;

                if (j < point[1]) col = j;
                else col = j + 1;
            }

            if (i < rowCount - 1 && j < colCount - 1)
                delMatrix[i, j] = matrix[row, col];
        }
    }

    return delMatrix;
}


Console.Clear();
int[,] matrix = GetMatrix(5, 7, -10, 10);
PrintMatrix(matrix);

int[] crossPoint = FirstMinElem(matrix);
Console.WriteLine($"Минимальный элемент {crossPoint[2]} на позиции ({crossPoint[0] + 1}, {crossPoint[1] + 1})");


int[,] delMatrix = DeleteRowCount(matrix, crossPoint);
Console.WriteLine("Удаление строки и столбца с минимальным элементом");
PrintMatrix(delMatrix);


