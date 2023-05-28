// Пользователь вводит с клавиатуры M чисел.
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.


Console.Write("Введите количество чисел: ");
int m = int.Parse(Console.ReadLine()); 
int count = 0; 
for (int i = 0; i < m; i++)
{
    Console.Write("Введите число: ");
    double num = double.Parse(Console.ReadLine()); 
    if (num > 0) 
    {
        count++; 
    }
}
Console.WriteLine("Количество чисел, больших 0: " + count);


