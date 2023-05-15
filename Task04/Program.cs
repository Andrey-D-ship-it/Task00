// Напиши программу, которая принимает на вход три числа и выдает максимальное из этих чисел.


Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b && a > c)
{
    Console.WriteLine($"{a} - максимальное число");
}
else if (b > a && b > c)
{
    Console.WriteLine($"{b} - максимальное число");
}
else if (c > a && c > b)
{
    Console.WriteLine($"{c} - максимальное число");
}
else
{
    Console.WriteLine("Числа равны");
}