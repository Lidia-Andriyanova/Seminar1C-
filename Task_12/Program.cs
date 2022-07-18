// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

int Rest (int num1, int num2) 
{
    int result = num1 % num2;
    return result;
}

Console.Clear();
Console.Write("Введите первое число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

int restDiv = Rest(firstNum, secondNum);
if (restDiv == 0) Console.WriteLine($"{firstNum}, {secondNum} -> кратно");
else Console.WriteLine($"{firstNum}, {secondNum} -> не кратно, остаток {restDiv}");