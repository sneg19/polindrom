// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();
Console.WriteLine("Введите пятизначное число");
int number = int.Parse(Console.ReadLine()!);
// 12345
int num1 = number % 10;
int num2 = number / 10000;
int num3 = number / 100 % 10;
int num4 = number / 1000 % 10;

if (num1 == num2 || num3 == num4) Console.WriteLine($"Число {number} является полиндромом");
else Console.WriteLine($"Число {number} не является полиндромом");