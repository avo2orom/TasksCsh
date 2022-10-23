// See https://aka.ms/new-console-template for more information
int[] arr = new int[5];

void newArray(int[] array)
{   
    Console.Write("Массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
        Console.Write(array[i] + " ");
    }
}

void InvertedArray(int[] array)
{
    for (int i = 0; i < (array.Length) / 2; i++)
    {
        int temporary = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = temporary;
    }
    Console.WriteLine();
    Console.Write("Перевернутый массив: ");
    for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
}

newArray(arr);
InvertedArray(arr);