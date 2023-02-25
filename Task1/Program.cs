// 1. Напишите программу, котрая на вход принимает два числа и проверяет, 
// является ли первое число квадратом второго

Console.Write("Введите число а = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b = ");
int b = Convert.ToInt32(Console.ReadLine());
if (a == b * b)
{
    Console.Write($"{a} является квадратом {b}");
}
else
{
    Console.Write($"{a} не является квадратом {b}");
}