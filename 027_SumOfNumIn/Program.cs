/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/ 

Console.Write("Введите число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
string numberNtext= Convert.ToString(numberN);

  int SumNumber(int numberN)
  {
    int a = 0;
    int result = 0;

    for (int i = 0; i < numberNtext.Length; i++){
      a = numberN - numberN % 10;
      result = result + (numberN - a);
      numberN = numberN / 10;
    }
   return result;
  }

int sumNumber = SumNumber(numberN);
Console.WriteLine(sumNumber);