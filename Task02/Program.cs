// Напиши программу, которая на вход принимает два числа и выдает, какое число больше, а какое меньшее.


Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine($"{numberA} больше, чем {numberB}");
}
else if (numberA < numberB)
{
    Console.WriteLine($"{numberB} больше, чем {numberA}");
}
else
{
    Console.WriteLine("Числа равны");
}