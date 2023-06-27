// # Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

int RandomNumber = new Random().Next (1,100);
Console.WriteLine($"Рандомное число - {RandomNumber}");

int digitone = RandomNumber % 10;
int digittwo = RandomNumber / 10;

if (digitone > digittwo) Console.WriteLine ($"бОльшая цифра {digitone}");
else Console.WriteLine($"бОльшая цифра {digittwo}");
