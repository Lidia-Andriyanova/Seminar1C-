// Напишите программу, которая бует преобразоывать
// десятичное число в двоичное
// 45 -> 101101
// 3 -> 11
// 2 -> 10

void ToBin(int n)
{
    if (n == 0) return;
    ToBin(n/2);
    Console.Write(n % 2);
}

Console.Clear();
ToBin(44);
 Console.WriteLine();