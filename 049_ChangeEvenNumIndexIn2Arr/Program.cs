/*Задача 49
Задайте двумерный массив. 
Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
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

void ChangeNumbersWithBothEvenIndex(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) //цикл для строк
    {
        for (int j = 0; j < matr.GetLength(1); j++) // цикл для столбцов
        {
            if (i % 2 == 0 & j % 2 == 0)
            {
                matr[i, j] = matr[i, j] * matr[i, j];
            }
        }
    }
}

Console.Write("Введите высоту матрицы: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите длинну матрицы: ");
int n = int.Parse(Console.ReadLine());

int[,] matrix = new int[m, n];

Console.WriteLine("Новый рандомный массив:");
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
Console.WriteLine("Массив с измененнными кратными элементами:");
ChangeNumbersWithBothEvenIndex(matrix);
PrintArray(matrix);