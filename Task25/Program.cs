// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int number1 = Input("Введите число А: ");
int number2 = Input("Введите натуральную степень В : ");
int mul = Exponentiation(number1, number2);
Console.WriteLine($"Число {number1} в степени {number2} равно {mul}");


int Exponentiation(int num1, int num2)
{
    int multi = num1;
    for (int i = 1; i < num2; i++)
    {
        checked {multi = num1 * multi;};
    }
    return multi;
}

int Input (string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

