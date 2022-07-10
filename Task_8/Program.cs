// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 2;
while (i <= num) {
    Console.Write($"{i} ");
    i += 2;
}
Console.WriteLine();