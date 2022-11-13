/*Задача 55: 
Задайте двумерный массив. 
Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
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

void ChangeColumnsAndRows(int[,] matr)
{   

    for (int i = 0; i < matr.GetLength(0) - 1; i++)
    {
        for (int j = i; j < matr.GetLength(1); j++)
        {
            int temp = matr[j, i];
            matr[j, i] = matr[i, j];
            matr[i, j] = temp;
        }
    }
}


int[,] matrix = new int[4, 4];

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
ChangeColumnsAndRows(matrix);
PrintArray(matrix);