// Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int GetDigits(int num)
{
    int result = 1;
    while (num >= 10) {
        num = num / 10;
        result++;
    }
    return result;
}

int digitCount = GetDigits(num);

Console.WriteLine($"Количество цифр в числе {num} =  {digitCount}");



