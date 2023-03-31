// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int rowMatrix = Input("Введите кол-во строк в массиве m: ");
int colMatrix = Input("Введите кол-во столбцов в массиве n: ");
int[,] newMatrix = CreateMatrixRndInt(rowMatrix, colMatrix, -10, 10);
PrintMatrix(newMatrix);
int[] sumRowArr = SumRows(newMatrix); // одномерный массив, элементы которого представляют сумму элементов строк двумерного массива
PrintArray(sumRowArr);
int minSumRows = MinElemetsArray(sumRowArr); // минимальный элемент в массиве
int position = ElementPosition(sumRowArr, minSumRows) + 1; // +1 т.к. считаем при выводе результатов нумерацию строк в двумерном массиве с 1
Console.WriteLine($"Строка № {position} имеет минимальную сумму элементов двумерного массива и равна {minSumRows}");


int ElementPosition(int[] arr2, int sumElemRows)
{
    int check = -1;
    for (int i = 0; i < arr2.Length; i++)
    {
        if (arr2[i] == sumElemRows) return i;
    }
    return check;
}

int MinElemetsArray(int[] arr1)
{
    int min = arr1[0];

    for (int i = 1; i < arr1.Length; i++)
    {
        if (arr1[i] < min) min = arr1[i]; 
    }
    return min;
}

int[] SumRows (int[,] matrix1)
{
    int[] arr = new int[matrix1.GetLength(0)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        int sumRows = 0;
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            sumRows += matrix1[i, j];
        }
        arr[i] = sumRows;
    }
    return arr;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine("|");
    }
    Console.WriteLine("");
}

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];

    Random rnd = new Random(); // создаем экземпляр класса вне цикла

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

int Input(string text)
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
    Console.WriteLine("");
}
