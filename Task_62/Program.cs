// Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void FillMatrix(int[,] matrix, int row, int col, int count, int vector)
{
    matrix[row, col] = count;
    count++;

    if (vector == 0) 
    {
        if (col + 1 < matrix.GetLength(1) && matrix[row, col + 1] == 0)
            col++;
        else 
            vector = 1;
    }
    if (vector == 1)
    {
        if (row + 1 < matrix.GetLength(0) && matrix[row + 1 , col] == 0)
            row++;
        else
            vector = 2;
    }
    if (vector == 2)
    {
        if (col - 1 >= 0 &&  matrix[row , col - 1] == 0)
            col--;
        else
            vector = 3;
    }
    if (vector == 3) 
    {
        if (row - 1 >= 0 && matrix[row - 1, col] == 0)
            row--;
        else if (col + 1 < matrix.GetLength(1) && matrix[row, col + 1] == 0)
        {
            col++;
            vector = 0;
        }
        else
            vector = 4;
    }

    if (vector != 4) 
         FillMatrix(matrix, row, col, count, vector);
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

Console.Clear();
int[,] matrix = new int[6, 8];

FillMatrix(matrix, 0, 0, 1, 0);
PrintMatrix(matrix);
