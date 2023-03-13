// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.


int a = Input("Введите число а: ");
int b = Input("Введите число b: ");
int c = Input("Введите число c: ");

Console.WriteLine(Triangle(a, b, c) == true ? "Yes" : "No");


bool Triangle(int num1, int num2, int num3)
{
    return num1 < num2 + num3 && num2 < num1 + num3 && num3 < num2 + num1;
}

int Input (string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

