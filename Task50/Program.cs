// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого 
// элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

int strok = Input("Введите кол-во строк в массиве m: ");
int stolb = Input("Введите кол-во столбцов в массиве n: ");
int[,] matrixNew = CreateMatrixRndInt(strok, stolb, -50, 50);

int lineMatrix = Input($"Введите индекс строки матрицы (от 0 до {strok - 1}): ");
int columnMatrix = Input($"Введите индекс столбца матрицы (от 0 до {stolb - 1}): ");

PrintMatrix(matrixNew);

bool check = CheckingIndexMatrix(lineMatrix, columnMatrix, matrixNew);
if (check == true) Console.WriteLine($"Значение элемента с индексами ({lineMatrix}, {columnMatrix}) равно {matrixNew[lineMatrix, columnMatrix]}");
else Console.WriteLine($"Значение элемента с индексами ({lineMatrix}, {columnMatrix}) не существует!");


bool CheckingIndexMatrix(int line, int column, int[,] matrix3)
{
    if (line > (matrix3.GetLength(0) - 1) || line < 0) return false;
    else if (column > (matrix3.GetLength(1) - 1) || column < 0) return false;
    else return true;
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
            Console.Write($"{matrix1[i, j],3}");
        }
        Console.WriteLine("|");
    }
}

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
