// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] array = CreateArrayRndInt(6, -10, 10);
PrintArray(array);
int[] arrayMulti = Multi(array);
PrintArray(arrayMulti);


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

int[] Multi(int[] array1)
{
    int size = array1.Length / 2; // размер нового массива при четном кол-ве элементов входдящего массива
    if (array1.Length % 2 != 0) size += 1; // размер нового массива при НЕчетном кол-ве элементов входдящего массива

    int[] array2 = new int[size];

    for (int i = 0; i < size; i++)
    {
        int p = array1.Length - 1; // индекс последнего элемента
        array2[i] = array1[i] * array1[p - i];
    }

    if (array1.Length % 2 != 0) array2[size - 1] = array1[array1.Length / 2];
    return array2;
}