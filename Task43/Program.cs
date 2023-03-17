// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем. b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int coefK1 = Input("Введите коэффициент k1: ");
int coefB1 = Input("Введите коэффициент b1: ");
int coefK2 = Input("Введите коэффициент k2: ");
int coefB2 = Input("Введите коэффициент b2: ");

if (coefK1 == coefK2) Console.WriteLine("Линии параллельны!");

else
{
    decimal[] array = IntersectionPointLines(coefK1, coefB1, coefK2, coefB2, 2);
    PrintArrayDecimal(array);
}

///////////////////////////////////////////////// Methods ////////////////////////////////////////////

decimal[] IntersectionPointLines(decimal k1, decimal b1, decimal k2, decimal b2, int decimalPlaces)
{
    decimal[] arrNew = new decimal[2];

    if (k1 == 0 && b1 != 0) // если линия 1 имеет вид y = const
    {
        Console.WriteLine($"Линия 1 иммет вид: y = {b1}");

        decimal y = Math.Round(b1, decimalPlaces);
        decimal x = Math.Round((y - b2) / k2, decimalPlaces);

        arrNew[0] = x;
        arrNew[1] = y;
        return arrNew;
    }

    else if (k2 == 0 && b2 != 0) // если линия 2 имеет вид y = const
    {
        Console.WriteLine($"Линия 2 иммет вид: y = {b2}");

        decimal y = Math.Round(b2, decimalPlaces);
        decimal x = Math.Round((y - b1) / k1, decimalPlaces);

        arrNew[0] = x;
        arrNew[1] = y;
        return arrNew;
    }

    else
    {
        decimal y = Math.Round((b2 - (k2 * b1) / k1) / (1 - (k2 / k1)), decimalPlaces);
        decimal x1 = Math.Round((y - b1) / k1, decimalPlaces);
        decimal x2 = Math.Round((y - b2) / k2, decimalPlaces);

        if (x1 == x2)
        {
            arrNew[0] = x1;
            arrNew[1] = y;
            return arrNew;
        }

        else // проверка, код ошибки: (-0, -0)
        {
            arrNew[0] = -0;
            arrNew[1] = -0;
            return arrNew;
        }
    }
}

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArrayDecimal(decimal[] arr)
{
    Console.Write("(");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i],3}, ");
        else Console.Write($"{arr[i],3}");
    }
    Console.WriteLine(")");
}
