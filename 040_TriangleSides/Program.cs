/*Задача 40: 
Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
*/ 
Console.Write("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 3: ");
int c = Convert.ToInt32(Console.ReadLine());

if((a + b > c) && (a + c > b) && (b + c > a))
    {
        Console.WriteLine("Треугольник существует");
    }
else
    {
        Console.WriteLine("Треугольник не существует");
    }