/*
Напишите программу, которая принимает на вход координаты x и у
x и y не равны 0
и выдает номер плоскости, в которой находится эта точка
2 | 1
_____
3 | 4
*/

Console.Write("Введите x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("1 четверть");
}

if (x < 0 && y > 0)
{
    Console.WriteLine("2 четверть");
}

if (x < 0 && y < 0)
{
    Console.WriteLine("3 четверть");
}

if (x > 0 && y < 0)
{
    Console.WriteLine("4 четверть");
}