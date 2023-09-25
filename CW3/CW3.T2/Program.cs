// Задача №17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причем X и Y не равны 0 и выдает
// номер четверти плоскости, в которой находится эта точка.

void CheckKoords(int x, int y)
{
    if (x > 0 && y > 0)
        System.Console.WriteLine("Это первая четверть");
    else if (x > 0 && y < 0)
        System.Console.WriteLine("Это четвертая четверть");
    else if (x < 0 && y < 0)
        System.Console.WriteLine("Это вторая четверть");
    else if (x < 0 && y > 0)
        System.Console.WriteLine("Это вторая четверть");
    else
        System.Console.WriteLine("Точка лежит на координатной оси");
}

int CheckKoords2(int x, int y)
{
    int result = 0;
    if (x > 0 && y > 0)
        result = 1;
    else if (x > 0 && y < 0)
        result = 4;
    else if (x < 0 && y < 0)
        result = 3;
    else if (x < 0 && y > 0)
        result = 2;
    return result;
}

System.Console.WriteLine("Введите координату X");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Y");
int y = Convert.ToInt32(Console.ReadLine());
CheckKoords(x, y);
System.Console.WriteLine($"Это четверть {CheckKoords2(x, y)}");
