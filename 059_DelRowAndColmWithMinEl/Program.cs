/* Задача 59: 
Задайте двумерный массив из целых чисел. 
Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим 
следующий массив:
9 2 3
4 2 4
2 6 7
*/


Console.Write("Введите высоту матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длинну матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];
int[,] matrix2 = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
int coordinateI = 0;
int coordinateJ = 0;

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
DeleteRowsAndColumns(matrix, matrix2);
Console.WriteLine(coordinateI);
Console.WriteLine(coordinateJ);
PrintArray(matrix2);


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


void DeleteRowsAndColumns(int[,] matr, int[,] matr2)
{
    int min = matr[0, 0];
    int flgI = 0;
    int flgJ = 0;

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] < min)
            {
                min = matr[i, j];
                coordinateI = i;
                coordinateJ = j;
            }
        }
    }


    for (int i = 0; i < matr.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < matr.GetLength(1) - 1; j++)
        {
            if (i < coordinateI)
            {
                flgI = 0;
            }

            else
            {
                flgI = 1;
            }

            if (j < coordinateI)
            {
                flgJ = 0;
            }

            else
            {
                flgJ = 1;
            }

            matr2[i, j] = matr[i + flgI, j + flgJ];
        }
    }
}

/*
int[,] array = new int[5, 5];
int[,] array2 = new int[array.GetLength(0) -1, array.GetLength(1) - 1];
int coordinateI = 0;
int coordinateJ = 0;

fillArray(array);
printArray(array);
deletingRowAndColumn(array, array2);
Console.WriteLine(coordinateI);
Console.WriteLine(coordinateJ);
printArray(array2);


void deletingRowAndColumn(int[,] matrix, int[,] array2){
    int min = matrix[0, 0];
    int flagI = 0;
    int flagJ = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i, j] < min) {
                min = matrix[i, j];
                coordinateI = i;
                coordinateJ = j;
            }
        }
    }
    for (int i = 0; i < matrix.GetLength(0) -1; i++)
    {
        for (int j = 0; j < matrix.GetLength(1) -1; j++)
        {
            if(i < coordinateI) {
                flagI = 0;
            } else {
                flagI = 1;
            }

            if(j < coordinateJ) {
                flagJ = 0;
            } else {
                flagJ = 1;
            }

            array2[i, j] = array[i + flagI, j + flagJ];
        }
    }
}

void fillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}


void printArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

*/