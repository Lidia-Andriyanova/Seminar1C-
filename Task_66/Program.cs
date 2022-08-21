// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Clear();
Console.Write("Задайте первое число M: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте второе число N: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int NumSum(int from, int to)
{
    int sum = 0;
    if (to < from) return 0;

    sum = sum + to + NumSum(from, to - 1);
    Console.Write($" {to}");
    return sum;
}

Console.Write($"M = {number1}; N = {number2} -> ");

int sum = 0;
if (number1 < number2)
    sum = NumSum(number1, number2);
else
    sum = NumSum(number2, number1);
Console.WriteLine();
Console.WriteLine($"Сумма чисел = {sum}");
