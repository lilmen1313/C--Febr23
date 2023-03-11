// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array2 = CreateArray (n);
PrintArray(array2);

int[] CreateArray (int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите значение элемента с индексом {i}: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void PrintArray (int[] array1)
{
    Console.Write("[");
    for (int i = 0; i < array1.Length; i++)
    {
        if (i < array1.Length-1) Console.Write($"{array1[i]}, ");
        else Console.Write($"{array1[i]}");
    }
    Console.Write("]");
}