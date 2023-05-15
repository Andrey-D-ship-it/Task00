// напиши программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N.


Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Четные числа от 1 до {N}:");
for (int i = 2; i <= N; i += 2)
{
    Console.Write($"{i} ");
}
