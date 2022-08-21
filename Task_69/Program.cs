// Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числоа: ");
int power = Convert.ToInt32(Console.ReadLine());


int NumPow(int num, int pow)
{
    int res = 1;
    if (pow == 0)
        return 1;
    else
        return res = res*num*NumPow(num, pow - 1);
}

int result = NumPow(number, power);
Console.WriteLine($"Число {number} в степени {power} = {result}");