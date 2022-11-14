/*Задача 69:
Напишите программу, которая на вход принимает два числа A и B, 
и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

Console.WriteLine("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write($"Число {a} в степени {b} равно: ");
Console.WriteLine(ExponentiationOfElementsInNumber(a, b));

int ExponentiationOfElementsInNumber(int n, int m)
{

    if (m == 1)
    {
        return n;
    }
    else
    { 
       return ExponentiationOfElementsInNumber(n, m - 1) * n;
    }
}