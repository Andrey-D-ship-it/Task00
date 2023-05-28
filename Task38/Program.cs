// Задайте массив вещественных чисел.
//  Найдите разницу между максимальным 
//  и минимальным элементов массива.


double[] array = new double[10];
Random random = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.NextDouble() * 100;
}
Console.WriteLine("Элементы массива:");
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}
double max = array[0];
double min = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    else if (array[i] < min)
    {
        min = array[i];
    }
}
double diff = max - min;
Console.WriteLine("Разница между максимальным и минимальным элементами: " + diff);


