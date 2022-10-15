/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
 и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
 

Console.Write("Введите число A: ");
string textA = Console.ReadLine();
int numberA = Convert.ToInt32(textA);
Console.Write("Введите число B: ");
string textB = Console.ReadLine();
int numberB = Convert.ToInt32(textB);

Console.WriteLine("Число А в степени числа B = " + Math.Pow(numberA, numberB));
*/

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int result = 1;

for (int i = 0; i < numberB; i++)
{
    result = result * numberA;
}
Console.WriteLine(result);
