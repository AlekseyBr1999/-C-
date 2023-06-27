// напишите программу, которая принимает число и выдаёт третью (слева) цифру, либо сообщает, что такой цифры нет
start:
 Console.WriteLine("малыш, введи число (100>)");
 int num = Convert.ToInt32(Console.ReadLine());
 if (num<100) 
 {
    Console.WriteLine("Нет третьей цифры");
    goto start;
 }
 else Console.WriteLine("Окей, сейчас");
 while (num>999) 
 {
     num = num / 10;
 }
 Console.WriteLine($"Третья цифра вашего числа - {num % 10}");
// Я ЧЕРТОВ ГЕНИЙ И ПОНЯЛ, КАК ВОЗВРАЩАТЬСЯ В НАЧАЛО ПРОГРАММЫ В СЛУЧАЕ НЕВЫПОЛНЕНИЯ УСЛОВИЯ