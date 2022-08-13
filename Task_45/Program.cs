// Напишите программу, которая будет создаваить
// копию заданного массива с помощью поэлементного копирования


int[] CopyArrayInt (int[] array)
{
    int size = array.Length;
    int[] newArray = new int[size]; 

     for (int i = 0; i < size; i++)
     {
         newArray[i] = array[i];     
     }

    return newArray;
}

int[]  CreateArrayRndInt (int size, int min, int max)
{
    int[] arr = new int[size]; 
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
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

int[] array = CreateArrayRndInt(8, 1, 20);

Console.Clear();   
PrintArray(array);
Console.WriteLine();   

int[] newArray = CopyArrayInt(array);
PrintArray(newArray);
Console.WriteLine();   
