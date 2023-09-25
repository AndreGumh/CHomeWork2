// Напишите программу, которая по заданному номеру четверти
// показывает диапазон возможных координат этой четверти (x и y).

string InfChetv (int Num)
{
    string result = "Введите нормальное значение";
    if (Num == 1)
    result = "В первой четверти x>0 и y>0";
else if (Num == 2)
    result = "Во второй четверти x<0 и y>0";
else if (Num == 3)
    result = "В третьей четверти x<0 и y<0";
else if (Num == 4)
    result = "В четвертой четверти x>0 и y<0";
    return result;
}

System.Console.WriteLine("Введите номер четверти");
int NumberKoord = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(InfChetv(NumberKoord));

// if (NumberKoord == 1)
//     System.Console.WriteLine("В первой четверти x>0 и y>0");
// else if (NumberKoord == 2)
//     System.Console.WriteLine("Во второй четверти x<0 и y>0");
// else if (NumberKoord == 3)
//     System.Console.WriteLine("В третьей четверти x<0 и y<0");
// else if (NumberKoord == 4)
//     System.Console.WriteLine("В четвертой четверти x>0 и y<0");
// else
//     System.Console.WriteLine("Введенное число не соответствует номеру четверти");