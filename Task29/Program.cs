// Напишите программу, 
// которая задаёт массив из 8 элементов 
// и выводит их на экран.



int[] array = new int[8];

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите {i + 1}-й элемент массива: ");
    array[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Элементы массива:");
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}





