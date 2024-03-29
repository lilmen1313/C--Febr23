﻿// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка от 10 до 99 -> {number}");

// if (firstDigit > secondDigit)
// {
//     Console.WriteLine($"Наибольшая цифра числа -> {firstDigit}");
// }
// else
// {
//     Console.WriteLine($"Наибольшая цифра числа -> {secondDigit}");
// }

int b = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа -> {b}");

int MaxDigit(int a) //method
{
    int firstDigit = a / 10;
    int secondDigit = a % 10;
    int result = firstDigit > secondDigit ? firstDigit : secondDigit;
    return result;
}