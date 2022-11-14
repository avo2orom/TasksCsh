/*Задача 66: 
Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.WriteLine("Введите число 1");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int n = Convert.ToInt32(Console.ReadLine());
int temp = 0;
Console.Write($"Сумма чисел между {m} и {n} равна: ");
printNaturalNumbers(m, n, temp);


void printNaturalNumbers(int m, int n, int sum)
{
    sum = sum + n;
    if (n <= m)
    {
        Console.Write($" {sum} ");
    }
    else
    {
    printNaturalNumbers(m, n - 1, sum);
    }
}


