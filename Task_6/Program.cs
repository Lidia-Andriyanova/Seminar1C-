// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int div = num % 2;
if (div == 0)
    Console.WriteLine("да");
else
    Console.WriteLine("нет");
