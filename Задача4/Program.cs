﻿// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int num3 = int.Parse(Console.ReadLine());
int maxNumber = num1;
if (num2 > maxNumber)
{
    maxNumber = num2;
}
else
{
    if (num3 > maxNumber)
    {
        maxNumber = num3;
    }
}
Console.WriteLine($"{maxNumber}");