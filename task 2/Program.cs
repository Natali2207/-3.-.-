// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости,
//  в которой находится эта точка.

void ShowQuarter(int x, int y)
{
    if (x > 0 & y > 0) Console.WriteLine ("Это первая четверть!");
    if (x < 0 & y > 0) Console.WriteLine ("Это вторая четверть!");
    if (x < 0 & y < 0) Console.WriteLine ("Это третья четверть!");
    if (x > 0 & y < 0) Console.WriteLine ("Это четвертая четверть!");
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int x = GetInput("Введите координату Х: ");
int y = GetInput("Введите координату Y: ");
ShowQuarter(x, y);

