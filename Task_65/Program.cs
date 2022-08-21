// Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


Console.Clear();
Console.Write("Задайте первое число M: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте второе число N: ");
int number2 = Convert.ToInt32(Console.ReadLine());


void NaturalNumber(int from, int to)
{
    if (from == to) 
        Console.Write(from);
    else if (from < to)
        NaturalNumberAsc(from, to);    
    else 
        NaturalNumberDesc(from, to);    
}

void NaturalNumberAsc(int from, int to)
{
    if (to < from) return;
    NaturalNumber(from, to - 1);
    Console.Write($" {to}");
}

void NaturalNumberDesc(int from, int to)
{
    if (to > from) return;
    NaturalNumber(from, to + 1);
    Console.Write($" {to}");
}

Console.Write($"M = {number1}; N = {number2} -> ");
NaturalNumber(number1, number2);
Console.WriteLine();