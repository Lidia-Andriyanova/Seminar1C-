// Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

bool IsSquare (int num1, int num2) 
{
    if (num1 * num1 == num2 || num2 * num2 == num1) return true;
    return false;
}

Console.Clear();
Console.Write("Введите первое число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

bool square = IsSquare(firstNum, secondNum);
if (square) Console.WriteLine($"{firstNum}, {secondNum} -> да");
else Console.WriteLine($"{firstNum}, {secondNum} -> нет");

