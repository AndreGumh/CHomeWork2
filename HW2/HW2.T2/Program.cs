// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int i = 0;
int b = num;
while (b != 0)
{
    b = b / 10;
    i++;
}
if (i <= 2)
{
    System.Console.WriteLine("Третьей цифры в числе нет");
}
else
{
  while (i != 3)
    {
        num = num / 10;
        i--;
    }
    num = num % 10;
    System.Console.WriteLine(num);  
}