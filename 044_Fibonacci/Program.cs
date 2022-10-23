/*

*/ 

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("0 1 ");
void Fibbonacci(int number)
{
    int number1 = 0;
    int number2 = 1;
    int next = 0;
    for (int i = 0; i < number; i++)
    {
        next = number1 + number2;
        Console.Write(next + " ");
        number1 = number2;
        number2 = next;
    }
}

Fibbonacci(number);