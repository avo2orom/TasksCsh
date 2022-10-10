/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 

Console.WriteLine("Введите трехзначное число");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 99 | n > 999)
{
    Console.WriteLine("Введено некорректное число");
    return;
}

else
{
    int n1 = n % 100;
    int n2 = n1 / 10;
    
    Console.WriteLine(n2);
}
*/

Console.WriteLine("Введите трехзначное число");

try {
int n = Convert.ToInt32(Console.ReadLine());

if (n < 99 | n > 999)
{
    Console.WriteLine("Введено некорректное число");
    return;
}

else
{
    int n1 = n % 100;
    int n2 = n1 / 10;
    
    Console.WriteLine(n2);
}
} 
catch (FormatException)
{
Console.WriteLine("Неверный формат");
}