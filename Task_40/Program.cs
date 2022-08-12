// Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины
// Каждая сторона треугольника меньше суммы двух других сторон


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

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
     if (i == 0) Console.Write("[");
     if (i < array.Length - 1) Console.Write(array[i] + ", ");
     else Console.Write(array[i] + "]");
    }
}

Boolean IsTriangle(int[] array)
{
    int sum = array[0] + array[1] + array[2];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= sum - array[i]) return false;
    } 
    return true;
}

int[] arr = CreateArrayRndInt(3, 1, 10);

Console.Clear();   
PrintArray(arr);
Console.WriteLine();   

if (IsTriangle(arr)) Console.WriteLine("Треугольник существует");   
else Console.WriteLine("Треугольник не существует");   
