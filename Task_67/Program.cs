// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int DigitSum(int num)
{
    int sum = 0;
    if (num == 0)
        return 0;
    else
        return sum = sum + num % 10 + DigitSum(num/10);
}

int sum = DigitSum(number);
Console.WriteLine($"Сумма цифр = {sum}");