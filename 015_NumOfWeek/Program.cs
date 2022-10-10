/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите день недели от 1 до 7, где 1 - это понедельник");

try
{
    int WeekDays = Convert.ToInt32(Console.ReadLine());

    if (WeekDays == 6 | WeekDays == 7)
    {
        Console.WriteLine("Ура, сегодня выходной!");
    }
    else if (WeekDays < 1 || WeekDays > 7)
    {
        Console.WriteLine("Извините, нет такого дня");
    }
    else 
    {
        Console.WriteLine("Ну вот, придется идти на работу");
    }
}
catch (FormatException)
{
    Console.WriteLine("Извините, но лучше числом");
}
