// Напишите программу, которая на вход принимает два числа и выдаёт первые N чисел, для которых каждое следующее равно сумме двух предыдущих.
// 3 и 4, N = 5 -> 3 4 7 11 18
// 6 и 10, N = 4 -> 6 10 16 26
Console.WriteLine("Сейчас покажу первые 6 значений.");
Console.WriteLine($"А с какого числа начнем?");
int Num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("А второе число?");
int Num2 = Convert.ToInt32(Console.ReadLine());
for (int count = 1; count < 4; count++)
{ 
    Console.Write($"{Num1}, {Num2}, ");
    Num1 = Num1 + Num2;
    Num2 = Num2 + Num1;
}
