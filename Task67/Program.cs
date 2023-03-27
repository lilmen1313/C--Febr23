// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int number = Input("Введите целое положительное число: ");

int num = SumNumbersDigits(number);
Console.Write(num);

int SumNumbersDigits(int n)
 {
     if (n == 0) return 0;
     else return n % 10 + SumNumbersDigits(n / 10);
 }

 int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}