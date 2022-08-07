// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным
// элементами массива.

double[]  CreateArrayRndDouble (int size, int min, int max)
{
    double [] arr = new double[size]; 
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(arr[i], 1);
    }
    return arr;
}

double DiffMinMaxElem(double[] array)
{
    double min = array[0];
    double max = min;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
    }
    double diff = max - min;
    return Math.Round(diff, 1);
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
     if (i == 0) Console.Write("[");
     if (i < array.Length - 1) Console.Write(array[i] + "; ");
     else Console.Write(array[i] + "]");
    }
}

double[] array = CreateArrayRndDouble(5, 1, 10);

Console.Clear();   
PrintArray(array);

double diff = DiffMinMaxElem(array);
Console.Write($" -> {diff}");
Console.WriteLine();

