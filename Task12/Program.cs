// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите число a: ");
int a =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b =Convert.ToInt32(Console.ReadLine());

int num = Remains(a, b);

if (num == 0)
{
    Console.WriteLine($"Первое число a = {a} кратно второму b = {b}");
}
else
{
    Console.WriteLine($"Остаток от деление a = {a} на b = {b} равен {num}");
}

int Remains (int num1, int num2)
{
    return num1 % num2;
}