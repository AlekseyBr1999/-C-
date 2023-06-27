// Напишите программу, которая на вход принимает трехзначное число и выдаёт вторую цифру этого числа

Console.WriteLine("Котёнок, введи, пожалуйста, трехзначное число");
int Num = Convert.ToInt32(Console.ReadLine());
if (Num < 100 || Num > 999) Console.WriteLine("Трехзначное, дундук");
else Console.WriteLine((Num - (Num % 10) - (Num / 100) *100) / 10);

