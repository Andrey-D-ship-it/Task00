// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212->нет

// 12821->да

// 23432->да



        Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());

int firstDigit = number / 10000;
int lastDigit = number % 10;
int secondDigit = (number / 1000) % 10;
int fourthDigit = (number / 10) % 10;

if (firstDigit == lastDigit && secondDigit == fourthDigit)
{
    Console.WriteLine("Число является палиндромом.");
}
else
{
    Console.WriteLine("Число не является палиндромом.");
}

