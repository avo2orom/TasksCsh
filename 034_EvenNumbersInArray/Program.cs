/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] arr = new int[5];

void newArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i < (array.Length - 1)) Console.Write($", ");

    }
    Console.WriteLine();
}

void NumberOfEvenNumbersInArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count = count + 1;
        }

    }
    Console.WriteLine(count);
}

Console.Write("Массив: ");
newArray(arr);
PrintArray(arr);
Console.Write("Количество чётных чисел в массиве: ");
NumberOfEvenNumbersInArray(arr);