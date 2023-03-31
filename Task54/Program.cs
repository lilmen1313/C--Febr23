// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int rowMatrix = Input("Введите кол-во строк в массиве m: ");
int colMatrix = Input("Введите кол-во столбцов в массиве n: ");
int[,] newMatrix = CreateMatrixRndInt(rowMatrix, colMatrix, 1, 5);
PrintMatrix(newMatrix);
SortRowsInDescendingOrder(newMatrix);
PrintMatrix(newMatrix);

void SortRowsInDescendingOrder(int[,] matrix1)
{
    int[] newArr = new int[matrix1.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        int max = matrix1[i, 0]; // фиксируем 1й столбец (принимаем первый элемент строки, как максимальный)

        do
        {
            for (int j = 0; j < matrix1.GetLength(1) - 1; j++)
            {
                if (max >= matrix1[i, j + 1])
                {
                    newArr[j] = max;
                    max = matrix1[i, j + 1];
                }
                else
                {
                    newArr[j] = matrix1[i, j + 1];
                    matrix1[i, j] = matrix1[i, j + 1];
                    matrix1[i, j + 1] = max;
                    max = matrix1[i, j + 1];
                }
            }
            max = matrix1[i, 0];
        }
        while (CheckRowsDescending(newArr));
    }
}

bool CheckRowsDescending(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (arr[i] < arr[i + 1]) return true;
    }
    return false;
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
