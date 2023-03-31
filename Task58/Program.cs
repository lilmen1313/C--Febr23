// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int rowMatrix1 = Input("Матрица1: Введите кол-во строк в массиве m: ");
int colMatrix1 = Input("Матрица1: Введите кол-во столбцов в массиве n: ");
int rowMatrix2 = Input("Матрица2: Введите кол-во строк в массиве m: ");
int colMatrix2 = Input("Матрица2: Введите кол-во столбцов в массиве n: ");

//проверка условия согласованности матриц
if (colMatrix1 != rowMatrix2)
{
    Console.WriteLine("Матрицы несогласованны! Кол-во элементов в строках матрицы1 неравно кол-ву элементов в столбцах матрицы 2");
    return;
}
int[,] newMatrix1 = CreateMatrixRndInt(rowMatrix1, colMatrix1, -50, 50);
int[,] newMatrix2 = CreateMatrixRndInt(rowMatrix2, colMatrix2, -50, 50);
PrintMatrix(newMatrix1);
PrintMatrix(newMatrix2);

int[,] multi2D = MultiMatrix(newMatrix1, newMatrix2);
PrintMatrix(multi2D);

int[,] MultiMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] multiMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int k = 0; k < matrix2.GetLength(1); k++) // столбцы матрицы2
    {
        for (int i = 0; i < matrix1.GetLength(0); i++) // строки матрицы1
        {
            int sum = 0;

            for (int j = 0; j < matrix1.GetLength(1); j++) // столбцы матрицы1
            {
                sum += matrix1[i, j] * matrix2[j, k]; // условие согласования матриц: кол-во строк м2 = кол-ву стролбцов м1
            }
            multiMatrix[i, k] = sum;
        }
    }
    return multiMatrix;
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
