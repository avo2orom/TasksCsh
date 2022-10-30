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
            matr[i, j] = new Random().Next(0,10);
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
    count = 0;
    for (int i = 0; i < matr.GetLength(0); i++) //цикл для строк
    {
        for (int j = 0; j < matr.GetLength(1); j++) // цикл для столбцов
        {
            for (int a = 0; a < n; a++) // цикл для рассчета
        {
            
        }
        }
    Console.WriteLine();
    }
}

Console.Write("Введите высоту матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длинну матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m,n];

FillArray(matrix);
PrintArray(matrix);
