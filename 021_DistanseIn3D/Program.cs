/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
AB = √(x1 - x2)2 + (y1 - y2)2 + (z1 - z2)2
*/ 

Console.Write("Введите x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());
double distance = (Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2)));
Console.WriteLine("Расстояние м-ду точками = " + Math.Round(distance,2));