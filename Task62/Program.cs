// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int sizeMatrix = Input("Введите размерность квадратного массива N: ");
int[,] arr2D = CreateMatrixIntSpiral(sizeMatrix);
PrintMatrix(arr2D);

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

int[,] CreateMatrixIntSpiral(int size)
{
    int[,] matrix = new int[size, size];

    int count = size;
    int position = 1; 
    int value = -size;
    int sum = -1;

    do
    {
        value = -1 * value / size; // 1; -1; 1; -1     // направление движения (1 - движемся вправо; -1 - влево)

        for (int i = 0; i < count; i++)
        {
            sum += value; // 0, 1, 2, 3; 14, 13, 12; 5, 6; 9.
            matrix[sum / size, sum % size] = position++;
        }

        value *= size; // 4; -4; 4; -4.     // направление движения
        count--; // 3; 2; 1; 0.    // ограничение движения

        for (int i = 0; i < count; i++)
        {
            sum += value; // 7, 11, 15; 8, 4; 10;
            matrix[sum / size, sum % size] = position++;
        }
    }
    while (count > 0);

    return matrix;
}

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

