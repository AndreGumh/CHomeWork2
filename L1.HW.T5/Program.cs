﻿// Задача 7 HARD по желанию - идет за 2 обязательных Напишите программу, которая принимает на вход 
// целое число любой разрядности и на выходе показывает третью цифру слева этого числа или 
// говорит, что такой цифры нет. Через строку решать нельзя.
// 456111 -> 6
// 78 -> нет
// 9146548 -> 4
// 3 -> нет

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int b = a / 10;

if (a > 100)
{
    while (b > 1000)
    {
        b = b / 10;
    }
    b = b % 10;
    Console.WriteLine(b);
}
else
{
    Console.WriteLine("У введенного число отсутствует третье число слева");
}