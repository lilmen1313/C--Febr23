// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine($"Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());

int y = Method (a);
Console.WriteLine($"Число {a} состоит из {y} цифры/-р");

int Method (int n)
{
    int i = 0;
    while (n != 0)
    {
        n = n / 10;
        i += 1;
    }
    return i;
}