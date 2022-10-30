/*Задача 50. 
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
[1,7] -> такого элемента в массиве нет
*/


void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) //цикл для строк
    {
        for (int j = 0; j < matr.GetLength(1); j++) // цикл для столбцов
        {
            matr[i, j] = i + j;
        }
    }
}

bool FindArrayPosition(int[,] matr, int n, int m)
{
    Console.Write("Введите элемент высоты матрицы: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите элемент длинны матрицы: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    bool position = false;
        if ((rows < m) && (columns < n))
        {
            position = true;
        }
    return position;
}

Console.Write("Введите высоту матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длинну матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];

FillArray(matrix);

string result = FindArrayPosition(matrix, m, n)? $"такой элемент в массиве есть" : $"такого элемента в массиве нет";
Console.WriteLine(result);