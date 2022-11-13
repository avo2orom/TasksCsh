/*Задача 54.1: 
Задайте двумерный массив. 
Напишите программу, которая упорядочит элементы по убыванию (или возрастанию).
*/

int[,] matrix = new int[4, 4];
int[] m1 = new int[16];

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) //цикл для строк
    {
        for (int j = 0; j < matr.GetLength(1); j++) // цикл для столбцов
        {
            matr[i, j] = new Random().Next(0, 100);
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

void ConvertArray(int[,] matr, int[] matr1)
{
    int z = 0;
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            matr1[z] = matr[i, j];
            z++;
        }
    }

    
}

void OrderArray1(int[] matr1)
{
    int temp;
    int z;
    for (int i = 0; i < m1.Length; i++)
    {
        for (z = 0; z < m1.Length - 1 - i; z++)
        {
            if (m1[z] > m1[z + 1])
            {
                temp = m1[z];
                m1[z] = m1[z + 1];
                m1[z + 1] = temp;
            }
        }
    }
}

void ConvertArrayBack(int[,] matr, int[] matr1)
{
    int z = 0;
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            matr[i, j] = matr1[z];
            z++;
        }
    }

    
}

Console.WriteLine("Массив: ");
FillArray(matrix);
PrintArray(matrix);
ConvertArray(matrix, m1);
OrderArray1(m1);
Console.Write("Отсортированный массив: ");
Console.WriteLine();
ConvertArrayBack(matrix, m1);
PrintArray(matrix);