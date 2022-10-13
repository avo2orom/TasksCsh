/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/ 

 Console.WriteLine("Введите пятизначное число");
int Number = Convert.ToInt32(Console.ReadLine());
string NumberText = Convert.ToString(Number);

void CheckingNumber(string NumberText)
{
if(NumberText[0] == NumberText[4] || NumberText[2] == NumberText[3])
{
    Console.WriteLine("Вау, это же палиндром!");
}
else 
{
    Console.WriteLine("Увы, это не палиндром:(");
}
}

if (NumberText!.Length == 5){
  CheckingNumber(NumberText);
}
else Console.WriteLine($"Введите правильное число");