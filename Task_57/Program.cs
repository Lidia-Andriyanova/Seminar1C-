// Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

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

int[] OneDimArray(int [,] matrix)
{
    int rowCount = matrix.GetLength(0);
    int colCount = matrix.GetLength(1);
    
    int[] simpleArray = new int[rowCount*colCount];
    int k = 0;

    for (int i = 0; i < rowCount; i++)
     {
        for (int j = 0; j < colCount; j++)
        {
            simpleArray[k] = matrix[i, j];
            k++;
        }
    }
    Array.Sort(simpleArray);
    return simpleArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
     if (i == 0) Console.Write("[");
     if (i < array.Length - 1) Console.Write(array[i] + "; ");
     else Console.Write(array[i] + "]");
    }
}

void PrintRepeat(int[] array)
{
    int elem = array[0];
    int count = 1;

    for (int i = 1; i < array.Length; i++)    
    {
        if (elem == array[i]) 
            count++;
        else 
        {
            Console.WriteLine($"{elem} встречается {count} раз(а)");   
            elem = array[i];
            count = 1;
        }
    }
   Console.WriteLine($"{elem} встречается {count} раз(а)");   
}

Console.Clear();
int[,] matrix = GetMatrix(5, 7, 1, 10);
PrintMatrix(matrix);

Console.WriteLine("В одну строку");
int[] array = OneDimArray(matrix);
PrintArray(array);
Console.WriteLine();

Console.WriteLine("частотный словарь");
PrintRepeat(array);
Console.WriteLine();





