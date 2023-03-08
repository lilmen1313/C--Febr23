// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int g = Reversal (n);
Console.WriteLine(n == g ? "Да" : "Нет");

int NumberOfDigits (int number1) // метод определения цифр в числе
{
    int count = 0;
    while (number1 != 0)
    {
        number1 = number1 / 10;
        count += 1;
    }
    return count;
}

int Reversal (int number2) // метод на разворот числа
{
    int result = 0;
    int numDig = NumberOfDigits(number2);
    for (int i = numDig - 1; i >= 0; i--)
    {
        int res = number2 % 10;
        result = result + res * Convert.ToInt32(Math.Pow(10 , i));
        number2 = number2 / 10;
    }
    return result;
}