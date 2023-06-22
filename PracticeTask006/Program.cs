// Напишите программу, которая принимает на ввод три числа и выдаёт максимальное из трёх чисел

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (num1 > num2) max = num1;
else max = num2; 
if (num3 >= max) max = num3;
Console.WriteLine("Max = ");
Console.Write(max);
