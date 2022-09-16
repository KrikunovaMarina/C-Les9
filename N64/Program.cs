Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine($"Все натуральные числа в промежутке от {n} до {m}:");

if (n<m)
{
for (int i = n; i <= m; i++)
    Console.Write($" {i}");
for (int i = m; i <= n; i++)
     Console.Write($" {i}");
}

