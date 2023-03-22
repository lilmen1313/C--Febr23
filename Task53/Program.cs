// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

int rowMatrix = Input("Введите кол-во строк в массиве m: ");
int colMatrix = Input("Введите кол-во столбцов в массиве n: ");

int[,] matrixNew = CreateMatrixRndInt(rowMatrix, colMatrix, -100, 100);
PrintMatrix(matrixNew);
LinePermutation(matrixNew);
PrintMatrix(matrixNew);


void LinePermutation(int[,] matrix1)
{
    for (int j = 0; j < matrix1.GetLength(1); j++)
    {
        int value = matrix1[0, j];
        matrix1[0, j] = matrix1[matrix1.GetLength(0) - 1, j];
        matrix1[matrix1.GetLength(0) - 1, j] = value;
    }
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
            Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine("|");
    }
    Console.WriteLine("");
}
