// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

int[] PairMultiplyArray(int[] array)
{
    int size = array.Length/2 + array.Length % 2;

    int [] newArray = new int[size]; 

    for (int i = 0; i < size; i++)
    {
        if (i != array.Length - 1 - i)  newArray[i] = array[i] * array[array.Length - 1 - i];
        else newArray[i] = array[i];
    }
    return newArray;
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

int[] array = CreateArrayRndInt(5, 1, 10);

Console.Clear();   
PrintArray(array);
Console.Write(" -> ");

int[] newArray = PairMultiplyArray(array);
PrintArray(newArray);
Console.WriteLine();
