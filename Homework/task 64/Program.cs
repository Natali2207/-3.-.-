// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int PrintNumberTo1Natural(int number)
{
    if (number == 1) return number;
    Console.Write(", " + (number - 1));
    return PrintNumberTo1Natural(number - 1);
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int number = GetInput("Введите число : ");
Console.Write($"N = {number} -> \"{number}");
PrintNumberTo1Natural(number);
Console.Write($"\"");
