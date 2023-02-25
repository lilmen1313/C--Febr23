// 7. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите целое трёхзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
    if (-1000 < a && a < -99 )
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(-a % 10);
    }
    else if (a > 99 && a < 1000)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write(a % 10);
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Введено не трехзначное число!");
    }