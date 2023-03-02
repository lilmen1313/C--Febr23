// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Method(n);

void Method (int a)
{
    if (a > 0)
    {
        for (int i = 1; i <= a; i++)
        {
            Console.WriteLine($"{i} -- {i * i}");
        }
        return;
    }
    else 
    {
        for (int i = 1; i >= a; i--)
        {
            Console.WriteLine($"{i} -- {i * i}");
        }
        return;
    }
}