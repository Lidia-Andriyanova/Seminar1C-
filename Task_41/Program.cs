// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int[]  FillArray (int size)
{
    int [] array = new int[size]; 

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i}-ое число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int PosNumCount (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}    


Console.Clear();
Console.Write("Введите количество чисел: ");
int count = Convert.ToInt32(Console.ReadLine());

int[] array = FillArray(count);

int posCount = PosNumCount (array);
Console.WriteLine($"Количество положительных введенных чисел: {posCount}");


