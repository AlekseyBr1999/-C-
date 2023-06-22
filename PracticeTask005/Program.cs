// Напишите программу, которая на вход принимает 2 числа и говорит какое из них большее, а какое меньшее.

Console.WriteLine("Рыбка моя, введи, пожалуйста, первое число: ");

int nomber1 = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("Введите, пожалуйста, второе число: ");

int nomber2 = Convert.ToInt32(Console.ReadLine()); 
int max = 0;
if (nomber1 > nomber2) max = nomber1;
else max = nomber2; 

Console.WriteLine ("Max = ");
Console.Write(max);