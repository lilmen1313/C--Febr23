// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите число a: ");
int a =Convert.ToInt32(Console.ReadLine());

if (Remains7and23(a))
{
    Console.WriteLine($"Число a = {a} кратно 7 и 23");
}
else
{
    Console.WriteLine($"Условие не выполняется");
}

bool Remains7and23 (int num1)
{
    return num1 % 7 == 0 && num1 % 23 == 0;
}