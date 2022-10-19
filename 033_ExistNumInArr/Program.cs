/*Задача 33: 
Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да*/

int[] arr = new int[5];

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

Console.Write("Массив: ");
newArray(arr);
PrintArray(arr);

Console.Write("Введите число, которое хотите найти: ");
int n = Convert.ToInt32(Console.ReadLine());

string result = FindNumber(arr, n)? $"Число {n} входит в массив" : $"Число {n} не входит в массив";
Console.WriteLine(result);

//поиск числа в массиве
bool FindNumber(int[] array, int n)
{
    bool h = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == n)
        {
            h = true;
            break;
        }
    }
    return h;
}