// Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

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

Boolean IsNumInArray(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num) return true;
    }
    return false;
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

int[] array = CreateArrayRndInt(12, -100, 100);

Console.Clear();   
PrintArray(array);
Console.WriteLine();

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Boolean numInArray = IsNumInArray(array, num);
if (numInArray) Console.WriteLine($"Число {num} есть в массиве");
else Console.WriteLine($"Числа {num} нет в массиве");