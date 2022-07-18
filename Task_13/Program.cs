// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int thirdDigit(int num) {

    if (num < 0) num = -num;

    if (num < 100) return -1;
    else
    {
        while (num >= 1000) 
        {
            num = num / 10;
        }
        int result = num % 10;
        return result;
    }
}

Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int resDigit = thirdDigit(num);
if (resDigit == -1) Console.WriteLine($"{num} -> третьей цифры нет");
else Console.WriteLine($"{num} -> {resDigit}");
