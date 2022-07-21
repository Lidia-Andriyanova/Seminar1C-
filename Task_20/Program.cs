// Напишите программу, которая
// принимает на вход координаты двух точек
// и находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

double Distance(int x1, int y1, int x2, int y2)
{
    double result = Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1));
    result = Math.Round(result, 2, MidpointRounding.ToZero);
    return result;
}

Console.Clear();
Console.WriteLine("Введите координаты первой точки: ");
Console.Write("X = ");
int Ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Y = ");
int Ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки: ");
Console.Write("X = ");
int Bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Y = ");
int By = Convert.ToInt32(Console.ReadLine());

double result = Distance(Ax, Ay, Bx, By);
Console.WriteLine($"Расстояние между точками {result}");