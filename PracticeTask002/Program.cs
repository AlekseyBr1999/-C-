// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда
//5 -> Пятница

Console.WriteLine("Введите цифру от 1 до 7: ");

int day = Convert.ToInt32(Console.ReadLine());

int mon = 1, tue = 2, wed = 3, thu = 4, fri = 5, sat = 6, sun = 7;

if (day == mon) Console.WriteLine("Понедельник");
if (day == tue) Console.WriteLine("Вторник");
if (day == wed) Console.WriteLine("Среда");
if (day == thu) Console.WriteLine("Четверг");
if (day == fri) Console.WriteLine("Пятница-развратница");
if (day == sat) Console.WriteLine("Суббота-неработа");
if (day == sun) Console.WriteLine("Воскресенье");

if (day > 7) Console.WriteLine("Введи нормальное число, дурак");
if (day < 1) Console.WriteLine("Введи нормальное число, дурак");