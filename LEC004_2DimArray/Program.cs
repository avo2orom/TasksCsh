// Двумерные массивы
//string[,]table = new string[2,3]; // массив строк ~= таблица
//[,] - двумерный массив
//[2,3] - две строки три столбца

//int[,] matrix = new int[5,8]; // таблица чисел

// индекс строк и столбцов начинаются с НУЛЯ
// table[0,0] table[0,1] table[0,2] ... table[0,n]
// table[1,0] table[1,1] table[1,2] ... table[1,n]
// table[n,0] table[n,1] table[n,2] ... table[n,n]

/*
// Пример массива со строкой
string[,] table = new string[2, 5];
table[1, 2] = "test";

for (int rows = 0; rows < 2; rows++) //цикл для строк
{
    for (int columns = 0; columns < 5; columns++) // цикл для столбцов
    {
        Console.Write($"-{table[rows, columns]}-");
    }
Console.WriteLine();
}

// пример массива с числами (матрица)

int[,] matrix = new int[3, 4];

for (int i = 0; i < matrix.GetLength(0); i++) //цикл для строк
{
    for (int j = 0; j < matrix.GetLength(1); j++) // цикл для столбцов
    {
        Console.Write($"{matrix[i, j]} ");
    }
Console.WriteLine();
}

*/

//функция печати двумерного массива


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

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) //цикл для строк
    {
        for (int j = 0; j < matr.GetLength(1); j++) // цикл для столбцов
        {
            matr[i, j] = new Random().Next(1,10);
        }
    }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);