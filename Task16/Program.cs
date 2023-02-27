// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите число a: ");
int a =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b =Convert.ToInt32(Console.ReadLine());

if (Square(a, b))
{
    if (a > b)
    {
    Console.WriteLine($"Первое число a = {a} является квадратом второго b = {b}");
    }
    else
    {
        Console.WriteLine($"Второе число b = {b} является квадратом первого a = {a}");
    }
}
else
{
    Console.WriteLine("Никакое из чисел не является квадратом другого числа");
}

bool Square (int num1, int num2)
{
    return num1 == num2 * num2 || num2 == num1 * num1;
}