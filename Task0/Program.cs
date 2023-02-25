// Напишите программу, котрая на вход принимает число и выдаёт его квадрат.
Console.Write("Введите целое число а = ");
int a = Convert.ToInt32(Console.ReadLine()); 
a *= a;
Console.WriteLine($"Квадрат числа a равен {a}");