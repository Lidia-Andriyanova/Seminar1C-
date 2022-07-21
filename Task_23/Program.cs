// Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Cube(int n) {
   int i = 1;

   while (i <= n) {
    Console.WriteLine($"---------------");    
    Console.WriteLine($"| {i, 4} | {i*i*i, 4} |");
    i++;
   }
   Console.WriteLine($"---------------");    
}

Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 0) Cube(num);
else Console.WriteLine("Введено не натуральное число");