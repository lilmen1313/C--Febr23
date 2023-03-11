// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int number1 = Input("Введите число А: ");
int summaDigits = SumDigits(number1);
Console.WriteLine($"Сумма цифр в числе {number1} равна {summaDigits}");

int SumDigits (int number)
{
    int sum = 0;
    while (number != 0)
    {
        sum += number % 10;
        number = number /10;
    }
    return sum;
}

int Input (string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
