// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int sizeArr = Input("Введите количество чисел: ");
int[] array = ManualFillingArray(sizeArr);
PrintArray(array);
int counter = SearchPositiveNumbers(array);
Console.WriteLine($"Количество положительных чисел: {counter}");

int SearchPositiveNumbers(int[] arr1)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i] > 0) count += 1;
    }
    return count;
}

int[] ManualFillingArray(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = Input($"Введите значение элемента с индексом {i}: ");
    }
    return arr;
}

int Input (string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
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

