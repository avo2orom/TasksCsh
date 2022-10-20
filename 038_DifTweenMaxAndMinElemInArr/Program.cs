/*Задача 38: 
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/


double[] arr = new double[5];

void newArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i < (array.Length - 1)) Console.Write($", ");

    }
    Console.WriteLine();
}

void FindDifferenceBetweenMaxAndMinNumbInArray(double[] array)
{
    double maxNumber = array[0];
    double minNumber = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxNumber)
        {
            maxNumber = array[i];
        }
        if (array[i] < minNumber)
        {
            minNumber = array[i];
        }
    }
    Console.WriteLine("Максимальное число массива: " + maxNumber + " минимальное число массива: " + minNumber);
    Console.WriteLine("Разница между максимальным и минимальным элементов массива: " + (maxNumber - minNumber));
}


Console.Write("Массив: ");
newArray(arr);
PrintArray(arr);
FindDifferenceBetweenMaxAndMinNumbInArray(arr);

