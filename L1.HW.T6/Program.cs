// Задача 2 HARD по желанию Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.
// 456 -> 3
// 0 -> 1
// 89,126 -> 5
// 0,001->4

Console.WriteLine("Введите число");
double a = Convert.ToDouble(Console.ReadLine());
double b = 1;
int c = 1;

if (a < 1)
{
    while (b != 0)
    {
        a = a * 10;
        b = a % 1;
        c++;
    }
    Console.WriteLine($"Количество цифр в числе равно {c}");
}
else
{
    while (b != 0)
    {
        a = a * 10;
        b = a % 1;
        c++;
    }
    b = a % 10;
    if (b != 0)
    {
        Console.WriteLine(a);
        while (a != 0)
        {
            a = a % 10;
            c++;
            break;
        }
        c++;
    }
    else
    {
        Console.WriteLine(a);
        while (a > 1)
        {
            a = a / 10;
            c++;
        }
        c = c-1;
    }
    Console.WriteLine($"Количество цифр в числе равно {c}");
}