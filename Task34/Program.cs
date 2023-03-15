// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве. [345, 897, 568, 234] -> 2

int siz0 = Input("Задайте размер массива: ");
int[] arr1 = CreateArrayRndInt(siz0);
int even = evenТumbers(arr1);
PrintArray(arr1);
Console.WriteLine($" в этом массиве {even} четных чисел(-а).");

void PrintArray (int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length-1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int[] CreateArrayRndInt(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(100, (999 + 1));
    }
    return arr;
}

int evenТumbers(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count +=1;
    }
    return count;
}

int Input (string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}