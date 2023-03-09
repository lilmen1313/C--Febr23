// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int n = Input("Введите число N: ");

CubeTable(n);

int Input (string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void CubeTable (int number)
{
    if (number > 1)
    {
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine($"{i} -- {i*i*i}");
        }
        return;
    }
    else
    {
        for (int i = 1; i >= number; i--)
        {
            Console.WriteLine($"{i} -- {i*i*i}");
        }
        return;
    }
}