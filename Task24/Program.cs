// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
int summa = Method(a);
Console.WriteLine($"Сумма чисел от 1 до {a} равнно {summa}");

int Method (int n)
{
    int sum = 0;
    for (int i = 1; i <= n; i++)
    {
        sum += i;
    }
    return sum;
}