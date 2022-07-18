// Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

bool IsDiv(int num)
{
    if (num % 23 == 0 && num % 7 == 0) return true;
    return false;
}

Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (IsDiv(num)) Console.WriteLine($"{num} -> да");
else Console.WriteLine($"{num} -> нет");