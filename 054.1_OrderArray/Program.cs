/*Задача 54.1: 
Задайте двумерный массив. 
Напишите программу, которая упорядочит элементы по убыванию (или возрастанию).
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

void OrderElementsInArrayString(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      for (int k = 0; k < matr.GetLength(1) - 1; k++)
      {
        if (matr[i, k] < matr[i, k + 1])
        {
          int temp = matr[i, k + 1];
          matr[i, k + 1] = matr[i, k];
          matr[i, k] = temp;
          
        }
      }
    }
  }
}

int[,] matrix = new int[4, 4];

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
OrderElementsInArrayString(matrix);
PrintArray(matrix);