// Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y)

string Coord(int quarter)
{
    if (quarter == 1) return "X больше ноля, Y больше ноля";
    if (quarter == 2) return "X меньше ноля, Y больше ноля";
    if (quarter == 3) return "X меньше ноля, Y меньше ноля";
    if (quarter == 4) return "X больше ноля, Y меньше ноля";
    return "Введена некорректная четверть";
}

Console.Clear();
Console.Write("Введите четверть: ");
int coordQuarter = Convert.ToInt32(Console.ReadLine());

string result = Coord(coordQuarter);
Console.WriteLine(result);
