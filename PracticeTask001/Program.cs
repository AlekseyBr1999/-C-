// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25; b = 5 -> да
// a = 2 b = 10 -> нет
// a = 9; b = -3 -> да
//a = -3 b = 9 -> нет

Console.WriteLine("Лапуль, дашь мне два числа для проверки?");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

bool result = false;
if (number2 == number1 * number1) result = true;

Console.WriteLine(result);