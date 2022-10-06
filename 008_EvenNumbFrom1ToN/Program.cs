/*Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/ 

/*
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());

while(1 <= n)
{
    if (n % 2 == 0)
    {
        Console.Write(n + " ");
        n--;
    }
    else n--;
}
*/

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int a = 1;

while (a <= n)
{
    if (a % 2 == 0)
    {
        Console.Write(a + " ");
        a++;
    }
    else a++;
}
