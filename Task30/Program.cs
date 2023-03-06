// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

Console.Write("Введите размер массива: ");
int a = Convert.ToInt32(Console.ReadLine());

int[] mas = Mass(a);
Print(mas);

int[] Mass(int n)
{
    int[] array = new int[n];
    Random ramd = new Random();

    for (int i = 0; i < n; i++)
    {
        array[i] = ramd.Next(0, 2);
    }
    return array;
}

void Print(int[] array11)
{
    for (int i = 0; i < array11.Length; i++)
    {
        Console.Write(array11[i] + " ");
    }
    return;
}