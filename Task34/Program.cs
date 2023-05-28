// Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, 
//  которая покажет количество чётных чисел в массиве.


int[] array = new int[8];
Random random = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(100, 1000);
}
Console.WriteLine("Элементы массива:");
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}
int evenCount = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        evenCount++;
    }
}
Console.WriteLine("Количество четных чисел в массиве: " + evenCount);
