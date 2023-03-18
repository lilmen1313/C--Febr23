// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int strok = Input("Введите кол-во строк в массиве m: ");
int stolb = Input("Введите кол-во столбцов в массиве n: ");
double[,] tabl = CreateMatrixRndDouble(strok, stolb, 10, 100);
PrintMatrixDouble(tabl);

void PrintMatrixDouble(double[,] matrix1)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            Console.Write($" {matrix1[i, j], 5} ");
        }
        Console.WriteLine("|");
    }
}

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] CreateMatrixRndDouble(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random(); // создаем экземпляр класса вне цикла

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double result = rnd.NextDouble() * (max - min) + min; // ----> построчно
            matrix[i, j] = Math.Round(result, 1);
        }
    }
    return matrix;
}
