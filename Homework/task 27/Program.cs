//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int SumDigitOfNumber2(string number)
{
    int[] arr = new int[number.Length];
    for (int i = 0; i < number.Length; i++) // преобразует строку в массив цифр
    {
        arr[i] = int.Parse(number[i].ToString());
    }
    int sum = 0;
    for (int k = 0; k < arr.Length; k++) // считает сумму элементов массива
    {
        sum = sum + arr[k];
    }
    return sum;
}

string Prompt(string text)
{
    Console.Write(text);
    return Console.ReadLine();
}

string num = Prompt("Введите число: ");
int sumValue = SumDigitOfNumber2(num);
Console.Write($"Сумма цифр числа {num} равна: {sumValue}");
