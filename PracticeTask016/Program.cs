// # Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
Console.WriteLine("Зайка, не порадуешь меня двумя числами?");
int Num1 = Convert.ToInt32(Console.ReadLine());
int Num2 = Convert.ToInt32(Console.ReadLine());

if (Num2 == Num1*Num1 || Num1 == Num2*Num2) Console.WriteLine("Да, является квадратом, солнышко");
else Console.WriteLine("Нет, не является(((");