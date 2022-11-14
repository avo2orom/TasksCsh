/*Задача 67: 
Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumOfElementsInNumber(number));

int SumOfElementsInNumber(int n)
{

    if (n < 10)
    {
        return n;
    }
    else
    { 
       return SumOfElementsInNumber(n / 10) + n % 10;
    }
}