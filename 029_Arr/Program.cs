/*
Задача 29: Напишите программу, которая задаёт массив произвольной длины, 
заполняет произвольными элементами и выводит их на экран.
Длину массива и элементы массива можно задать рандомно или попросить пользователя ввести в консоли.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

int[] arr = new int[0];

//пользователь вводит длинну массива
void newArrayP(int[] arr)
{   
    int n;
    Console.Write("Введите длинну массива: ");
    n = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[n];
}

//длинну массива определяет рандом
void newArrayR(int[] arr)
{   
    int ArrayLengthR = new Random().Next(0,1000);
    int[] a = new int[ArrayLengthR];
    Console.WriteLine("Длинна массива составляет " + ArrayLengthR);
}

//заполняет массив пользователь
void fillArrayP(int[]array)
{   
    
    for (int i=0; i < array.Length; i++)
    {
        Console.Write("Введите элемент массива: ");
        array[i] = int.Parse(Console.ReadLine());
    }
}
//заполняет массив рандом
void fillArrayR(int[]array)
{
    for (int i=0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,50);
    }
}

//печать массива
void PrintArray(int[]array)
{
    for (int i=0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i < (array.Length-1)) Console.Write($", ");

    }
    Console.WriteLine();
}


