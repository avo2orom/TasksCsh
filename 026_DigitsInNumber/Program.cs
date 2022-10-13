/*Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

//Версия 1 - 
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 0;

while (N>0)
{
    count+=1;
    N = N/10;
}
Console.WriteLine($"{count}");

//Версия 2 - 
/*
Console.Write("Введите число: ");
string number = Console.ReadLine();
int length = number.Length;
Console.WriteLine (length);
*/