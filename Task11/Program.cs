// Напишите программу, 
// которая выводит случайное 
// трехзначное число и удаляет вторую цифру 
// этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000); // (100, 999+1)
Console.WriteLine($"Случайное число из отрезка 100 - 999 -> {number}");

int DeleteSecodDigit (int num)
{
    int firstDigit = num / 100;
    int thirdDirit = num % 10;
    int needDigit = firstDigit * 10 + thirdDirit;
    return needDigit;
}

int result = DeleteSecodDigit(number);
Console.WriteLine($"{number} -> {result}");
