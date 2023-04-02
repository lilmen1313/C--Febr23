// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int number = Input("Введите целое положительное число N: ");
NaturalNumbersInterval(number);

void NaturalNumbersInterval(int num)
{
    if(num <= 0) return; // условие выхода
    if (num == 1) Console.Write($"{num}");
    else Console.Write($"{num}, ");
    NaturalNumbersInterval(num - 1);
}

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
