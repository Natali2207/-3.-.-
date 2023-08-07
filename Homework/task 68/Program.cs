﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int GetAkkermanFunction(int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberN == 0) return GetAkkermanFunction(numberM - 1, 1);
    return GetAkkermanFunction(numberM - 1, GetAkkermanFunction(numberM, numberN - 1));
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int numberM = GetInput("Введите число m: ");
int numberN = GetInput("Введите число n: ");
Console.WriteLine($"m = {numberM}; n = {numberN} -> A (m, n) = {GetAkkermanFunction(numberM, numberN)}");