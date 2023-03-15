// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int n = Input("Введите количество N первых чисел Фибоначи: ");
int[] arr = Fibonacci(n);
PrintArray(arr);

int[] Fibonacci(int size)
{
    int[] array = new int[size];

    array[0] = 0;
    array[1] = 1;

    for (int i = 2; i < size; i++)
    {
        array[i] = array[i-2] + array[i-1];
    }

    return array;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
