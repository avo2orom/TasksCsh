/*Задача 24
Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/

Console.Write("Введите число: ");

int A = int.Rarse(Console.Read.Line()); //int A = Convert.ToInt32(Console.ReadLine()); - это аналогично
int sum = 0;
for (int i=1; i<=A; i++)
{
    sum = sum +1
}
Console.WriteLine($"Сумма от 1 до {A}: {sum}");
