// Задача 13: Вывод 3 цифры числа если есть.

Console.Clear();

int varA;
while (true)
{
    Console.Write("Введите, пожалуйста целое число: ");
    if (int.TryParse(Console.ReadLine(), out varA))
        break;
    Console.WriteLine($"Ошибка ввода!");
}

if (varA < 0)
{
    Console.WriteLine("Введенное Вами число- отрицательное. Введите число больше 0.");
}
else
{
    if (varA < 100)
    {
        Console.WriteLine("Введенное Вами число- двузначное. В нем нет 3-й цифры");
    }
    else
    {
        varA = (varA / 100) % 10; Console.WriteLine($"Третье число равно {varA}");
    }
}
Console.WriteLine();
