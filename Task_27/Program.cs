// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int GetSumDigits(int num)
{
    int sum = num % 10;
    while (num >= 10) {
        num = num / 10;
        sum = sum + num % 10;
    }
    return sum;
}

int digitSum = GetSumDigits(num);

Console.WriteLine($"Сумма цифр в числе {num} =  {digitSum}");

