// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// k1 = 5, b1 = 2, k2 = 9, b2 = 4 -> (-0,5; -0,5)

double [] CrossPoint(double k1, double b1, double k2, double b2)
{
    double[] point = new double[3];

    if (k1 == k2)
    {
        if (b1 == b2) point[0] = 0;
        else point[0] = 1;
    }
    else 
    {
        point[0] = 2;
        point[1] = (b2 - b1)/(k1 - k2);
        point[2] = k1 * point[1] + b1;
    }
    return point;
}

Console.Clear();

Console.WriteLine("Уравнение прямой y = k1 * x + b1");
Console.Write("Введите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Уравнение прямой y = k2 * x + b2");
Console.Write("Введите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

double[] point = CrossPoint(k1, b1, k2, b2);

if (point[0] == 0) Console.WriteLine("Прямые совпадают. Бесконечно много точек пересечения.");
else if (point[0] == 1) Console.WriteLine("Прямые параллельны. Нет точек пересечения.");
else Console.WriteLine($"Точка пересечения прямых ({point[1]}, {point[2]})");

