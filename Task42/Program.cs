// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int a = Input("Введите число а: ");
Console.WriteLine(Translation(a));

int Translation(int num)
{
    int result = 0;
    int dec = 1;

    while (num != 0)
    {
        int remainder = num % 2;
        result = result + remainder * dec;
        dec = dec * 10;
        num = num / 2;
    }
    return result;
}

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}