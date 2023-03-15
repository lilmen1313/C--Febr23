// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int size0 = Input("Введите размер массива: ");
int nim0 = Input("Введите минимальный размер элемента массива: ");
int max0 = Input("Введите максимальный размер элемента массива: ");

int[] array = CreateArrayRndInt(size0, nim0, max0);
PrintArray(array);

int[] copyArr = CopyArray(array);
copyArr[0] = 10000; // проверка
PrintArray(copyArr);


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

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] CopyArray(int[] arr1)
{
    int[] copyArr = new int[arr1.Length];

    for (int i = 0; i < arr1.Length; i++)
    {
        copyArr[i] = arr1[i];
    }
    return copyArr;
}

