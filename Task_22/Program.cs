// Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 3 -> 1, 4, 9
// 5 -> 1, 4, 9, 16, 25

void Square(int n) {
   int i = 1;

   while (i <= n) {
    Console.WriteLine($"-------------");    
    Console.WriteLine($"| {i, 3} | {i*i, 3} |");
    i++;
   }
   Console.WriteLine($"-------------");    
}

Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 0) Square(num);
else Console.WriteLine("Введено не натуральное число");