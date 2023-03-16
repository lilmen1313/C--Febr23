// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int size0 = Input("Введите размер массива: ");
int nim0 = Input("Введите минимальный размер элемента массива: ");
int max0 = Input("Введите максимальный размер элемента массива: ");

int[] array = CreateArrayRndInt(size0, nim0, max0);
int sumElem = SumOddElemens(array);
PrintArray(array);
Console.WriteLine($" --> {sumElem}");

int SumOddElemens(int[] arr1)
{
    int sum = 0;
    for (int i = 1; i < arr1.Length; i += 2)
    {
        sum += arr1[i];
    }
    return sum;
}

int[] CreateArrayRndInt (int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
