Console.Clear();

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
int b = 0;

while (b <= a)
{
    if ((b % 2) == 0)
    {
        Console.WriteLine($"{b} ");
        b++;
    }
    else
    {
        b++;
    }
}