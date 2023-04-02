// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int numberM = Input("Введите целое неотрицательное число M: ");
int numberN = Input("Введите целое неотрицательное число N: ");

int funcAkk = FunctionAkkerman(numberM, numberN);
Console.WriteLine($"A({numberM}, {numberN}) = {funcAkk}");

int FunctionAkkerman(int numM, int numN)
{
    while (numM != 0)
    {
        if (numN == 0) numN = 1;
        else
        {
            numN = FunctionAkkerman(numM, numN - 1);
        }
        numM = numM - 1;
    }
    return numN + 1;
}

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}