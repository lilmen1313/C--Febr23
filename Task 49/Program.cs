// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

int strok = Input("Введите кол-во строк в массиве m: ");
int stolb = Input("Введите кол-во столбцов в массиве n: ");
int[,] matrixNew = CreateMatrixRndInt(strok, stolb, 10, 50);

PrintMatrix(matrixNew);
Console.WriteLine("_________________________");
EvenIndexSquare1(matrixNew);
PrintMatrix(matrixNew);

void EvenIndexSquare(int[,] matrix1)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            if (i % 2 ==0 && j % 2 ==0) matrix1[i, j] *= matrix1[i, j];
        }
    }
}

void EvenIndexSquare1(int[,] matrix1)
{
    for (int i = 0; i < matrix1.GetLength(0); i += 2)
    {
        for (int j = 0; j < matrix1.GetLength(1); j +=2)
        {
            matrix1[i, j] *= matrix1[i, j];
        }
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
