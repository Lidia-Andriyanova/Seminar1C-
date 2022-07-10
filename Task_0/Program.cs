Console.Clear();
Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int res =  num*num;
Console.WriteLine($"Квадрат числа {num} = {res}");