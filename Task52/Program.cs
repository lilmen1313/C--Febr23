// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int strok = Input("Введите кол-во строк в массиве m: ");
int stolb = Input("Введите кол-во столбцов в массиве n: ");
int[,] matrixNew = CreateMatrixRndInt(strok, stolb, -70, 70);

PrintMatrix(matrixNew);
double[] averageArr = AverageColumns(matrixNew);
Console.Write("Среднее арифметическое каждого столбца: ");
PrintArrayDouble(averageArr);

double[] AverageColumns(int[,] matrix2)
{
    double[] arr = new double[matrix2.GetLength(1)];
    
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        double result = 0;
        
        for (int i = 0; i < matrix2.GetLength(0); i++)
        {
            result += matrix2[i, j];
        }

        arr[j] = Math.Round(result / matrix2.GetLength(0), 1);
    }
    return arr;
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

void PrintMatrix(int[,] matrix1)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            Console.Write($"{matrix1[i, j], 4}");
        }
        Console.WriteLine("|");
    }
}

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArrayDouble(double[] arr1)
{
    for (int i = 0; i < arr1.Length; i++)
    {
        if (i < arr1.Length - 1) Console.Write($"{arr1[i],3}; ");
        else Console.Write($"{arr1[i],3}.");
    }
}
