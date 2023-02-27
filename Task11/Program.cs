// 11.Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трёхзначное число -> {number}");

int ToDigit (int a)
{
    int b = a /100;
    int c = a % 10;
    int d = b *10 + c;
    return d;
}

int y = ToDigit(number);
Console.WriteLine($"Если у числа {number} убрать вторую цифру то получим число -> {y}");