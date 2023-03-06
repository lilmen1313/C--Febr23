// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());

int d = Method(a);

if (a >=0) Console.WriteLine($"Произведение чисел от 1 до {a} равнно {d}");
else Console.WriteLine($"Введено отрицательное число!");

int Method (int n)
{
    int proiz = 1;
    for (int i = 1; i <= n; i++)
    {
        proiz *= i;
    }
    return proiz;
}