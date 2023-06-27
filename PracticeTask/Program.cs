// Напишите программу, которая на вход принимает цифру от 1 до 7 и сообщает, является ли этот день выходным

start:
Console.WriteLine("котик, введи, пожалуйста, цифру от 1 до 7");
int day = Convert.ToInt32(Console.ReadLine());
if (day > 7 || day < 1) 
{
    Console.WriteLine("Не меньше 1 и не больше 7, зай");
    goto start;
}
else 
    if (day < 6) Console.WriteLine("Нет, это будний день");
    else Console.WriteLine("Да, это выходной");