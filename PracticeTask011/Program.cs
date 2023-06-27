// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
//456 -> 46
//782 -> 72
//918 -> 98

int number = new Random() .Next(99,1000); 
Console.WriteLine($"Ваше случайное число - {number}"); 
int digitone = (number / 100)*10;
int digittwo = (number % 10);
int newnumber = digitone + digittwo; 
Console.WriteLine($"Вторая цифра удалена: {newnumber} "); 


// Второе решение
//int number = new.Random.Next(99,1000); 
//Console.WriteLine($"Ваше случайное число - {number}"); 
//int newnumber = (number % 100) + ((number / 10) * 10);
//Console.WriteLine($"Вторая цифра удалена: {newnumber} "); 