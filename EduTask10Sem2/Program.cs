// Задача 13: Вывод 3 цифры числа если есть.

Console.Clear();

//Console.WriteLine("Введите, пожалуйста Ваше число: ");
//string InNumA = Console.ReadLine() ?? "";
//int numA = int.Parse(InNumA);

int varA;
while (true)
{
    Console.Write("Введите число: ");
    if (int.TryParse(Console.ReadLine(), out varA))
        break;
    Console.WriteLine($"Ошибка ввода!");
}

//int a1 = 0, a2 = 0;

if (varA <= 999)
{
    if (varA > 99)
    {
        //a1 = varA % 100;
        //a2 = a1 / 10;
        Console.WriteLine($"{(varA % 100) / 10}");
    }
    else
    {
        Console.WriteLine("Вы нарушили условия задачи: ввели двузначное число. Введите, пожалуйста трехзначное число.");
    }
}
else
{
    Console.WriteLine("Вы превысили разрядность. Введите, пожалуйста трехзначное число.");
}
Console.WriteLine();
