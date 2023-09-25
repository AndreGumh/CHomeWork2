// Задача №17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причем X и Y не равны 0 и выдает
// номер четверти плоскости, в которой находится эта точка.

System.Console.WriteLine("Введите координату X");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Y");
int y = Convert.ToInt32(Console.ReadLine());

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