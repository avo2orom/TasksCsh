/*
Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

int len = new Random().Next(5,10);
int[] arr = new int[len];
double half = Math.Round((Convert.ToDouble(len)/2));
int[] arr2 = new int[Convert.ToInt32(half)];

void newArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
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

int [] MulElementsInArr(int[] array, int[] array2)
{
    int mul = 0;
    for (int i = 0; i < (array.Length)/2; i++)
    {
        array2[i] = array [i] * array [array.Length - 1 -i];
    }
        if(array.Length % 2 !=0)
        {
            array2[array.Length / 2] = array[array.Length / 2];
        }
    return array2;
}

Console.Write("Массив: ");
newArray(arr);
PrintArray(arr);

MulElementsInArr(arr, arr2);

Console.Write("Массив второй: ");
PrintArray(arr2);