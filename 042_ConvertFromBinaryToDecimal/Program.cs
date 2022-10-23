/*Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/ 
/*
Вариант 1. Читерский 

string text = "";
while (a != 0)
{
text += a % 2;
a = a/2;
}
char[] arr = text.ToCharArray();
Array.Reverse(arr);
Console.WriteLine(arr);
*/

Console.WriteLine("Введите число");

int number = Convert.ToInt32(Console.ReadLine());

// перевод в двоичную систему
string count = null;
while (number != 0)
{
count += number % 2; // два здесь - система исчисления, есди 3 - то будет троичная и тп
number /= 2; // два здесь - система исчисления, есди 3 - то будет троичная и тп
}

//вывод строки с обратной стороны
for (int i = count.Length - 1; i >= 0; i--)
{
Console.Write(count[i]);
}