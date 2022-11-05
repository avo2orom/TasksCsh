/*Задача 51: 
Задайте двумерный массив. 
Найдите сумму элементов, находящихся на главной диагонали
ГЛАВНАЯ ПАРАЛЛЕЛЬ = [0,0] [1,1] [2,2] [n,n]
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


Console.Write("Введите высоту матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длинну матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());


int[,] matrix = new int[m, n];

Console.WriteLine("Новый рандомный массив:");
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
