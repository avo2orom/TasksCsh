/*Задача 31
Сделайте массив из 12 элементов заполненный рандомными числами от -9 до 9
Найдите сумму отрицательных и положительныъ элементов массива
*/ 

int[] arr = new int[12];

void newArray(int[]array)
{
    for (int i=0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9,10);
    }
}

void PrintArray(int[]array)
{
    for (int i=0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i < (array.Length-1)) Console.Write($", ");

    }
    Console.WriteLine();
}

void SumOfPositiveAndNegative(int [] array)
{
    int positive = 0;
    int negative= 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array [i] >= 0)
        {
        positive = positive + array [i];
        }
        else
        {
        negative = negative + array [i];
        }
    }

    Console.WriteLine("Сумма положительных чисел в массиве: " + positive);
    Console.WriteLine("Сумма отрицательных чисел в массиве: " + negative);
}
Console.Write("Массив: " );
newArray(arr);
PrintArray(arr);
SumOfPositiveAndNegative(arr);