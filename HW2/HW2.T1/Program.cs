// Задача 10: Напишите программу, которая принимает на вход трёхзначное
// число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.WriteLine("Введите трехзначное число");
int num1 = Convert.ToInt32(Console.ReadLine());
int a = num1 / 100;
int b = num1 % 10;
int c = (num1 - a * 100 - b) / 10;
Console.WriteLine(c);