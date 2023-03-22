// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

int rowMatrix = Input("Введите кол-во строк в массиве m: ");
int colMatrix = Input("Введите кол-во столбцов в массиве n: ");

int[,] matrixNew = CreateMatrixRndInt(rowMatrix, colMatrix, 1, 10);
PrintMatrix(matrixNew);
int[] arrMinElem = MinElemIndexes(matrixNew);
PrintArray(arrMinElem);
int[,] matrixNew1 = DeleteMinRowColumn(matrixNew, arrMinElem[0], arrMinElem[1]);
PrintMatrix(matrixNew1);

int[,] DeleteMinRowColumn(int[,] matrix1, int rowDel, int culumnDel)
{
    int[,] matrix2 = new int[matrix1.GetLength(0) - 1, matrix1.GetLength(1) - 1];
    int m = 0, n = 0; // счетчики для входящего в метод массива

    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        if (m == rowDel) m++;
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            if (n == culumnDel) n++;
            matrix2[i, j] = matrix1[m, n];
            n++;
        }
        n = 0;
        m++;
    }
    return matrix2;
}

int[] MinElemIndexes(int[,] matrix)
{
    // int[] array = new int[matrix.Length];

    int indexRow = 0, indexColumn = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < matrix[indexRow, indexColumn])
            {
                indexRow = i;
                indexColumn = j;
            }
        }
    }
    return new int[] { indexRow, indexColumn };
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
