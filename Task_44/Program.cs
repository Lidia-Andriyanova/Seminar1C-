// Не используя рекурсию, выведите первые N числе Фибоначии. 
// Первые два числа Фибоначчи: 0 и 1
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int[] Fibonacci(int num)
{
    int[] array = new int[num];

    if (num >= 1) array[0] = 0;
    if (num >= 2) array[1] = 1;

    for (int i = 2; i < num; i++)
    {
        array[i] =  array[i - 1] + array[i - 2];
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
     Console.Write(array[i] + " ");
    }
}

Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] array = Fibonacci(num); 
Console.WriteLine("Числа Фибоначчи:");
PrintArray(array);
Console.WriteLine();
