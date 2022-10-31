/*Задача 52. 
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) //цикл для строк
    {
        for (int j = 0; j < matr.GetLength(1); j++) // цикл для столбцов
        {
            matr[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) //цикл для строк
    {
        for (int j = 0; j < matr.GetLength(1); j++) // цикл для столбцов
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ArithmMeanInEachColumn(int[,] matr)
{
    for (int i = 0; i < 4; i++)
    {
        int count = 0;
        for (int t = 0; t < 3; t++)
        {
            count += matr[t, i];
        }
        Console.Write($"{Math.Round(((float)count / 3), 2)}; ");
    }
}

int[,] matrix = new int[3, 4];

FillArray(matrix);
PrintArray(matrix);
ArithmMeanInEachColumn(matrix);