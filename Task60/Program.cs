// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет 
// построчно выводить массив, добавляя индексы каждого элемента.Массив размером 2 x 2 x 2
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int rowMatrix = Input("Введите кол-во строк в массиве m: ");
int colMatrix = Input("Введите кол-во столбцов в массиве n: ");
int depthMatrix = Input("Введите глубину массива l: ");

if (rowMatrix*colMatrix*depthMatrix + 9 > 100)
{
    Console.WriteLine("Уменьшите размер массива!");
    return;
}
int[,,] array3D = Create3DMatrixRndInt(rowMatrix, colMatrix, depthMatrix, 10);
Print3DMatrix(array3D);


void Print3DMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k],3} ({i}, {j}, {k}) ");
            }
        }
        Console.WriteLine();
    }
}

int[,,] Create3DMatrixRndInt(int rows, int columns, int depth, int min)
{
    int[,,] matrix3D = new int[rows, columns, depth];
    Random rnd = new Random(); // создаем экземпляр класса вне цикла
   
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                matrix3D[i, j, k] = min++;
            }
        }
    }
    return matrix3D;
}

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
