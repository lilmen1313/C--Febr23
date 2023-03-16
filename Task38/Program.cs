// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

int size0 = Input("Введите размер массива: ");
int nim0 = Input("Введите минимальный размер элемента массива: ");
int max0 = Input("Введите максимальный размер элемента массива: ");

double[] array = CreateArrayRndDouble(size0, nim0, max0);
double max1 = MaxElements(array);
double min1 = MinElements(array);
Console.WriteLine($"Значение максимального элемента: {max1}");
Console.WriteLine($"Значение минимального элемента: {min1}");
PrintArray(array);
Console.WriteLine($" --> {Math.Round((max1 - min1), 1)}");

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        double result = rnd.NextDouble()*(max - min) + min;
        arr[i] = Math.Round(result, 1);
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}; ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

double MaxElements(double[] arr1)
{
    double max = arr1[0];
    for (int i = 1; i < arr1.Length; i++)
    {
        if (arr1[i] > max) max = arr1[i];
    }
    return max;
}

double MinElements(double[] arr2)
{
    double min = arr2[0];
    for (int i = 1; i < arr2.Length; i++)
    {
        if (arr2[i] < min) min = arr2[i];
    }
    return min;
}
