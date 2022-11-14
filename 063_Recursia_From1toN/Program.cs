/*Задача 63: Задайте значение N. 
Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/ 

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

PrintNaturalNumber(number);

void  PrintNaturalNumber(int n)
{
    int number = 1;
    if(number == n)
    {
        Console.Write($"{n} ");
    }
    else
    {
        PrintNaturalNumber(n-1);
        Console.Write($"{n} ");
    }
}

/*
второй вариант решения:
Console.WriteLine("Введите число");

int number = Convert.ToInt32(Console.ReadLine());

printNaturalNumbers(1);


void printNaturalNumbers(int n) {

if(n == number ) {
Console.Write(n);
} else {
Console.Write(n);
printNaturalNumbers(n+1);
}
}
*/ 