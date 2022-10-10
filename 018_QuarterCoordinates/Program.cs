/*Задача 18
Напишите программу, которая по заданному номеру четверти, показывает диапазон
возможных координат точек в этой четверти (x, y)


Console.Write("Введите номер четверти от 1-4: ");
int x = Convert.ToInt32(Console.ReadLine());

if (x == 1)
{
    Console.WriteLine("диапазон возможных координат: x > 0 && y > 0");
}

if (x == 2)
{
    Console.WriteLine("диапазон возможных координат: x < 0 && y > 0");
}

if (x == 3)
{
    Console.WriteLine("диапазон возможных координат: x < 0 && y < 0");
}

if (x == 4)
{
    Console.WriteLine("диапазон возможных координат: x > 0 && y < 0");
}
if (x > 4 | x < 1)
{
    Console.WriteLine("Вы ввели некорретное число");
}

*/
Console.Write("Введите номер четверти от 1-4: ");
string x = Console.ReadLine();

if (x == "1")
{
    Console.WriteLine("диапазон возможных координат: x > 0 && y > 0");
}
else if (x == "2")
{
    Console.WriteLine("диапазон возможных координат: x < 0 && y > 0");
}
else if (x == "3")
{
    Console.WriteLine("диапазон возможных координат: x < 0 && y < 0");
}
else if (x == "4")
{
    Console.WriteLine("диапазон возможных координат: x > 0 && y < 0");
}
else 
{
    Console.WriteLine("Вы ввели некорретное число");
}

/*
bool one = true;
while (one)
{
try
{
Console.WriteLine("Введите номер четверти");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 0 && num <= 4)
{
if (num == 1)
{
Console.WriteLine("x > 0 и y > 0");
}
if (num == 2)
{
Console.WriteLine("x < 0 и y > 0");
}
if (num == 3)
{
Console.WriteLine("x < 0 и y < 0");
}
if (num == 4)
{
Console.WriteLine("x > 0 и y < 0");
}
one = false;
} else Console.WriteLine("Вы не попали в диапазон чисел от 1 до 4");
}
catch
{
Console.WriteLine("Ошибка ввода, попробуйте еще раз: ");
}
}
*/