﻿// Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int GetProduct(int num)
{
    int result = 1;
    for (int i = 1; i <= num; i++)
    {
        result = result*i;
    }

    return result;
}

int result = GetProduct(num);

Console.WriteLine($"Произведение чисел от 1 до {num} = {result}");

