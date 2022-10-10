/* Задача 21
Напишите программу, которая принимаеи на вход координату двух точек и находит
расстояние м-ду ними в 2D пространстве.

AB = √(xb - xa)2 + (yb - ya)2
*/

Console.Write("Введите x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Расстояние м-ду точками = "+ Math.Round((Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)),2));