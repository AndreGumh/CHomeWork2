// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите число, обозначающее день недели (от 1 до 7)");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 1 && num <= 5)
{
    System.Console.WriteLine("День недели не выходной");
}
else
{
    if (num == 6 || num == 7)
    {
        System.Console.WriteLine("День недели выходной");
    }
    else
    {
        System.Console.WriteLine("Число не соответствует дню недели");
    }
}