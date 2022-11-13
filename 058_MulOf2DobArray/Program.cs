/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
А В
1 4 | 3 5
3 5 | 1 2
Результирующая матрица будет:
С
7 13
14 25

Произведением двух матриц А и В называется матрица С, элемент которой, находящийся на пересечении i-й строки и j-го столбца, 
равен сумме произведений элементов i-й строки матрицы А на соответствующие (по порядку) элементы j-го столбца матрицы В.

С (0,0) = А(0,0) * B(0,0) + A(0,1) * B(1,0) = 1 · 3 + 4 · 1 = 3 + 4 = 7
С (0,1) = А(0,0) * B(0,1) + A(0,1) * B(1,1) = 1 · 5 + 4 · 2 = 5 + 8 = 13
С (1,0) = А(1,0) * B(0,0) + A(1,1) * B(1,0) = 3 · 3 + 5 · 1 = 9 + 5 = 14
С (1,1) = А(1,0) * B(0,1) + A(1,1) * B(1,1) = 3 · 5 + 5 · 2 = 15 + 10 = 25

Произведение двух матриц АВ имеет смысл только в том случае, когда число столбцов матрицы А совпадает с числом строк матрицы В.
В произведении матриц АВ число строк равно числу строк матрицы А , а число столбцов равно числу столбцов матрицы В.
*/

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) //цикл для строк
    {
        for (int j = 0; j < matr.GetLength(1); j++) // цикл для столбцов
        {
            matr[i, j] = new Random().Next(1, 10);
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

Console.Write("Введите высоту матрицы 1: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длинну матрицы 1: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите высоту матрицы 2: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длинну матрицы 2: ");
int n1 = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];
int[,] matrix2 = new int[m1, n1];
int[,] matrix3 = new int[matrix.GetLength(0), matrix2.GetLength(1)];

Console.WriteLine("Матрица 1:");
FillArray(matrix);
PrintArray(matrix);

Console.WriteLine("Матрица 2:");
FillArray(matrix2);
PrintArray(matrix2);

Console.WriteLine("Матрица 3:");
MatrixMultiplication(matrix, matrix2, matrix3);
PrintArray(matrix3);


void MatrixMultiplication(int[,] matr1, int[,] matr2, int[,] matr3)
{
    if (matr1.GetLength(1) != matr2.GetLength(0))
    {
        Console.WriteLine("Умножение невозможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
    }

    else
    {
        for (int i = 0; i < matr3.GetLength(0); i++)
        {
            for (int j = 0; j < matr3.GetLength(1); j++)
            {
                int sum = 0;
                for (int k = 0; k < matr1.GetLength(1); k++)
                {
                    sum += matr1[i, k] * matr2[k, j];
                }
                matr3[i, j] = sum;
            }
        }
    }
}