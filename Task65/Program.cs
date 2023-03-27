// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

int numberM = Input("Введите целое положительное число M: ");
int numberN = Input("Введите целое положительное число N: ");
NaturalNumbersMtoN(numberM, numberN);

void NaturalNumbersMtoN(int numM, int numN)
{
    if (numM < numN)
    {
        Console.Write($"{numM} ");
        NaturalNumbersMtoN(numM + 1, numN);
    }

    else if (numM > numN)
    {
        Console.Write($"{numM} ");
        NaturalNumbersMtoN(numM - 1, numN);
    }

    else
    {
        Console.Write($"{numM}");
    }
}

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
