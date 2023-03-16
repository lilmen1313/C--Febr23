// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int strok = Input("Введите кол-во строк в массиве m: ");
int stolb = Input("Введите кол-во столбцов в массиве n: ");
int[,] matrixNew = CreateMatrixRndInt(strok, stolb, 10, 50);
PrintMatrix(matrixNew);
int summa = SumMainDiagonal(matrixNew);
Console.WriteLine($"Сумма главной диагонали равна {summa}");

int SumMainDiagonal(int[,] matrix1)
{
    int sum = 0;

    int size = matrix1.GetLength(0);
    if (size > matrix1.GetLength(1)) size = matrix1.GetLength(1);
    
    for (int i = 0; i < size; i++)
    {
        sum += matrix1[i, i];
        // for (int j = 0; j < matrix1.GetLength(1); j++)
        // {
        //     if (i == j) sum += matrix1[i, j];
        // }
    }
    return sum;
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

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 5}");
            
        }
        Console.WriteLine("|");
    }
}

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
