// Напишите программу, которая на вход принимает число и говорит, является ли оно четным

Console.WriteLine("Зайка, введи, пожалуйста, число ");

int num = Convert.ToInt32(Console.Read());
bool answer = false;
if (num %2 == 0) answer = true;
if (answer == true) Console.WriteLine ("Чётное, зай");
else Console.WriteLine ("Нечётное, зай");
