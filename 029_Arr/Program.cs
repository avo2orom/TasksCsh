/*
Задача 29: Напишите программу, которая задаёт массив произвольной длины, 
заполняет произвольными элементами и выводит их на экран.
Длину массива и элементы массива можно задать рандомно или попросить пользователя ввести в консоли.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

//пользователь вводит длинну массива
int[] newArrayP()
{   
    int n;
    Console.Write("Введите длинну массива: ");
    n = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[n];
    return arr;
}

//длинну массива определяет рандом
int[] newArrayR()
{   
    int ArrayLengthR = new Random().Next(0,1000);
    int[] a = new int[ArrayLengthR];
    Console.WriteLine("Длинна массива составляет " + ArrayLengthR);
    return a;
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
        array[i] = new Random().Next(0,1000);
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

//Запускаем вручную!

int[] a1 = newArrayP();
fillArrayP(a1);
PrintArray(a1);

//Запускаем рандом!

int[] a2 = newArrayR();
fillArrayR(a2);
PrintArray(a2);