// Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] array = GetRandomArray(8);
PrintArray(array);

int[] GetRandomArray(int arrayLength)
{
    Random rnd = new Random();
    int[] array = new int[arrayLength];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 2);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Clear();
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1) Console.Write(",");
    }
    Console.Write("]");
    Console.WriteLine();
}

