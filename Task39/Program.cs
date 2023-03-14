// Задача 39. Напишите программу, которая перевернёт одномерный массив
// [1, 2, 3, 4, 5] --> [5, 4, 3, 2, 1]

int[] arr2 = CreateArrayRndInt(7, 1, 9);
PrintArray(arr2);
ReversalArray(arr2);
PrintArray(arr2);
Array.Reverse(arr2);
PrintArray(arr2);

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random(); // создаем экземпляр класса вне цикла

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
    Console.WriteLine("]");
}

//  0  1  2  3  4
// [1, 2, 3, 4, 5] --> [5, 4, 3, 2, 1]

void ReversalArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        int end = array.Length -1;
        array[i] = array[end - i];
        array[end - i] = temp;
    }
}

