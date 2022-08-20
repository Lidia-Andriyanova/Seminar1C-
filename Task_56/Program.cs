// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

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

int[] RowSumMatrix(int[,] matrix)
{
    int rowCount = matrix.GetLength(0);
    int colCount = matrix.GetLength(1);
    int[] sumArray = new int[rowCount];

    for (int i = 0; i < rowCount; i++)
        for (int j = 0; j < colCount; j++)
            sumArray[i] += matrix[i, j];

    return sumArray;
}

 void PrintRowSum(int[] sumArray)
 {
     int min = sumArray[0];
     Boolean anyPrint = false;

     for (int i = 0; i < sumArray.Length; i++)
     {
         Console.WriteLine($"Сумма элементов в {i + 1, 2}-ой строке = {sumArray[i], 2}");

         if (sumArray[i] < min) min = sumArray[i];
     }

     Console.Write($"Минимальная сумма элементов = {min} в строках: ");
     for (int i = 0; i < sumArray.Length; i++)
     {
         if (sumArray[i] == min)
         {
            if (anyPrint) Console.Write(", ");
            Console.Write($"{i + 1}");
            anyPrint = true;
         }
     }
     Console.WriteLine();
}


Console.Clear();
int[,] matrix = GetMatrix(7, 5, 1, 11);
PrintMatrix(matrix);

int[] sumArray = RowSumMatrix(matrix);
PrintRowSum(sumArray);