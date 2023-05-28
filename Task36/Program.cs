//  Задайте одномерный массив, заполненный случайными числами. 
//  Найдите сумму элементов, стоящих на нечётных позициях.


int[] array = new int[10];
Random random = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(1, 100);
}
Console.WriteLine("Элементы массива:");
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}
int sum = 0;
for (int i = 1; i < array.Length; i += 2)
{
    sum += array[i];
}
Console.WriteLine("Сумма элементов, стоящих на нечетных позициях: " + sum);