// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

Console.WriteLine("Введите целое число a: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($"Число {a} чётное, т.к. кратно двум");
    }
else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"Число {a} нечётное, т.к. не кратно двум");
    }