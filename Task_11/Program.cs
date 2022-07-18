// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int DelMidDigit(int number)
{
    int firstDigit = number / 100;
    int thirdDigit = number % 10;

    int result = firstDigit * 10 + thirdDigit;
    return result;
}

int num = new Random().Next(100, 1000);
int newNum = DelMidDigit(num);
Console.WriteLine($"{num} -> {newNum}");