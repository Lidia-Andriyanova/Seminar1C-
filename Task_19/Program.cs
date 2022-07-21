// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool Palindrome(int num)
{
    int temp = num;
    int backNum = 0;
    int lastDigit;
    
    while (temp > 0) {
        lastDigit = temp % 10;
        backNum = backNum * 10 + lastDigit;
        temp = temp / 10;
    }
    return num == backNum;
}

Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

bool result = Palindrome(num);
if (result) Console.WriteLine($"{num} -> да");
else Console.WriteLine($"{num} -> нет");
