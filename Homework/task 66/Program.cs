﻿// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int PrintSumOfRange(int startValue, int finishValue, int sum)
{
    sum = startValue;
    if (startValue == finishValue) return sum;
    return sum + PrintSumOfRange(startValue + 1, finishValue, sum);
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int numberM = GetInput("Введите число M: ");
int numberN = GetInput("Введите число N: ");
int sum = 0;
Console.Write($"M = {numberM}; N = {numberN} -> {PrintSumOfRange(numberM, numberN, sum)}");
