// Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.

int[]  CreateArrayRndInt (int size, int min, int max)
{
    int [] arr = new int[size]; 
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

int OddIndexSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1) sum += array[i];
    }
    return sum;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
     if (i == 0) Console.Write("[");
     if (i < array.Length - 1) Console.Write(array[i] + ", ");
     else Console.Write(array[i] + "]");
    }
}

int[] array = CreateArrayRndInt(4, -100, 100);

Console.Clear();   
PrintArray(array);

int sum = OddIndexSum(array);
Console.Write($" -> {sum}");
Console.WriteLine();

