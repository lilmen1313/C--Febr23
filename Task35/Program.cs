// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] array = CreateArrayRndInt(123, -100, 200);
PrintArray(array);
int a = QuantityPerInterval(array, 10, 99);
Console.WriteLine($"Количество элементов, значения которых входят в диапазон от 10 до 99 равно {a}");

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

void PrintArray (int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length-1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int QuantityPerInterval (int[] array1, int min, int max)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i] >= min && array1[i] <= max) count += 1;
    }
    return count;
}
