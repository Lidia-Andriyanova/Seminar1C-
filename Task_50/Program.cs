// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

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

int[] GetElement(int [,] matrix, int row, int col)
{
    int[] element = new int[2];
    int rowIndex = row - 1;
    int colIndex = col - 1;

    if (rowIndex >= 0 && rowIndex < matrix.GetLength(0)
        && colIndex >= 0 && colIndex < matrix.GetLength(1))
    {
        element[0] = 1;
        element[1] = matrix[rowIndex, colIndex];
    } 
    else
        element[0] = 0;

    return element;
}

Console.Clear();
int[,] matrix = GetMatrix(5, 5, 1, 10);
PrintMatrix(matrix);

Console.Write("Введите номер строки (нумерация начинается с 1): ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер колонки (нумерация начинается с 1): ");
int col = Convert.ToInt32(Console.ReadLine());

int[] result = GetElement(matrix, row, col);
if (result[0] == 1) Console.WriteLine($"Элемент на позиции ({row}, {col}) = {result[1]}");
else Console.WriteLine($"Элемента на позиции ({row}, {col}) в массиве нет");