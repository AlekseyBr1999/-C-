// Напишите программу, которая на вход принимает число (N), а на выходе выдаёт чётные числа от одного до N

Console.WriteLine("Солнышко, а можешь, пожалуйста, ввести число?");

int N = Convert.ToInt32(Console.ReadLine());

int Number = 1;

while (Number <= N) {
    if (Number %2 == 0) Console.Write(Number);
    Console.Write(" ");
    Number = Number + 1;
}
