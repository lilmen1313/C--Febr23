// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine($"Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
int num1 = Method(a);
if (num1 >= 0) Console.WriteLine($"Третья цифра числа {a} равна {num1}");
else Console.WriteLine($"У числа {a} третьей цифры нет");

int Method (int num)
{
    if (num > 99 && num < 1000) return num = num % 10;
    else if (num > -1000 && num < -99) return num =-num % 10;
    else if (num > 999) 
    {   while (num > 999)
        {
            num = num /10;
        }
        return num = num % 10;
    }
    else if (num < -999) 
    {   while (num < -999)
        {
            num = num /10;
        }
        return num = -num % 10;
    }
    else return num = -1;
}