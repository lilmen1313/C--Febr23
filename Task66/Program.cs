// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int numberM = Input("Введите целое положительное число N: ");
int numberN = Input("Введите целое положительное число M: ");

if (numberM < numberN) Console.WriteLine($"Сумма натуральных элементов на промежутке [{numberM}, {numberN}] равна {SumNaturalNumbersInterval(numberM, numberN)}");
else if (numberM > numberN) Console.WriteLine($"Сумма натуральных элементов на промежутке [{numberN}, {numberM}] равна {SumNaturalNumbersInterval(numberM, numberN)}");

int SumNaturalNumbersInterval(int numM, int numN)
{
    int sum = numM;

    if (numM < numN)
    {
        sum += SumNaturalNumbersInterval(numM + 1, numN);
    }
        
    else if (numM > numN)
    {
        sum += SumNaturalNumbersInterval(numM - 1, numN);
    }
    return sum;
}

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
