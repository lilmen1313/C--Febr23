// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// РЕКУРСИЯ - вызов функции самой себя.

int number = Input("Введите целое положительное число N: ");
NaturalNumbers(number);

void NaturalNumbers(int num)
{
    if(num == 0) return; // условие выхода
    NaturalNumbers(num - 1);
    Console.Write($"{num} ");
}

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

