/*Задача 31
Напишите программу замены положительных элементов массива на отрицательные 
*/

int[] arr = new int[4];

void newArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
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

void ChangePositiveAndNegative(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * (-1);
    }
}
Console.Write("Массив: ");
newArray(arr);
PrintArray(arr);
Console.Write("Новый массив: ");
ChangePositiveAndNegative(arr);
PrintArray(arr);