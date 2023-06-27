// # Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число некратно первому, то программа выводит остаток от деления.
//34, 5 -> некратно, остаток 4
//16, 4 -> кратно

Console.WriteLine("Введите два числа: ");
int Num1 = Convert.ToInt32(Console.ReadLine());
int Num2 = Convert.ToInt32(Console.ReadLine());

if (Num1 % Num2 == 0) Console.WriteLine("кратно");
else Console.WriteLine($"некратно, {Num1 % Num2}");
