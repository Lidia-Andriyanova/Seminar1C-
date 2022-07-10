Console.Clear();
Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int last = num % 10;
Console.WriteLine($"Последняя цифра: {last}");
