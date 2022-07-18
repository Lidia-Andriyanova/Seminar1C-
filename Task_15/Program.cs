// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int Weekend(int num)
{
    if (num >= 1 && num <= 5) return 0;
    if (num == 6 || num == 7) return 1;
    return -1;
}


Console.Clear();
Console.Write("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

int dayOfWeek = Weekend(day);

if (dayOfWeek == 0) Console.WriteLine($"{day} -> нет");
else if (dayOfWeek == 1) Console.WriteLine($"{day} -> да");
else Console.WriteLine($"{day} не является днем недели");



