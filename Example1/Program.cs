Console.Clear();

Console.WriteLine("Введите число a");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число b");
int b = int.Parse(Console.ReadLine());

if (a > b)
{
    Console.WriteLine($"Число {a} больше числа {b}");
}
else
{
    Console.WriteLine($"Число {b} больше числа {a}");
}