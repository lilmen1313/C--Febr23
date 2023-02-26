// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите целое число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N > 0) // если N положительное целое число
{
    Console.WriteLine($"Все целые чётные числа от 1 до {N}");
    for (int i = 1; i <= N; i++)
    {
        if (i % 2 == 0)
        {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write($"{i} ");
        }
    }
}
else // если N отрицительное целое число
{
    Console.WriteLine($"Все целые чётные числа от 1 до {N}");
    N = -N;
    for (int i = 1; i <= N; i++)
    {
        int a = -i; // вводим переменную для хранения обратного от i (отрицительного)
        if (i % 2 == 0)
        {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write($"{a} ");
        }
    }
}