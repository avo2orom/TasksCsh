
/*Задача 28: Напишите программу, которая принимает на вход число N 
и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120 


//Вариант 1
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int mul = 1;

for (int i = 1; i <= n; i++ )
{
    mul = mul * i;
}
Console.WriteLine(mul);
*/

//В2 с функцией
int num = int.Parse(Console.ReadLine());
int result = addition(num);
Console.WriteLine(result);

int x = addition(num + 1);
Console.WriteLine(x);

int addition(int number) // функция
{
    int count = 1;
    
    for (int i = 1; i <= number; i++)
    {
        count = count * i; // count *= i;
    }

    return count;
}