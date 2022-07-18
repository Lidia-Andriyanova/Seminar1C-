// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


int secondDigit(int number)
{
    int twoDigitNum = number / 10;
    int result = twoDigitNum % 10;

    return result;
}

Console.Clear();
Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num <= 999) 
{
    int digit = secondDigit(num);
    Console.WriteLine($"{num} -> {digit}");
}
else Console.WriteLine("Число не трехзначное");
