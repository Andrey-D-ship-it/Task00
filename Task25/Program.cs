// Напишите цикл, 
// который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.


Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите степень B: ");
int b = int.Parse(Console.ReadLine());

int result = 1;

for (int i = 1; i <= b; i++)
{
    result *= a;
}

Console.WriteLine($"{a} в степени {b} = {result}");
