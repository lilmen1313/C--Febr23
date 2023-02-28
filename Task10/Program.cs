// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine($"Введите трёхзначное число a: ");
int a = Convert.ToInt32(Console.ReadLine());
int num1 = Method(a);
if (num1 >= 0) Console.WriteLine($"Вторая цифра числа {a} равна {num1}");
else Console.WriteLine($"Число {a} не является трёхзначным");

int Method (int num)
{
    if (num > 99 && num < 1000) return num = (num / 10) % 10;
    else if (num > -1000 && num < -99) return num = (-num / 10) % 10;
    else return num = -1;
}