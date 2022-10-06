// Задача 10: Выбор второй цифры трёхзначнго числа.

Console.Clear();

Console.WriteLine("Введите, пожалуйста трехзначное число. ");
string InNumA = Console.ReadLine() ?? "";
int numA = int.Parse(InNumA);

int a1 = 0, a2 = 0;

if (numA < 999)
{
    if (numA > 99)
    {
        a1 = numA % 100;
        a2 = a1 / 10;
        Console.WriteLine(a2);
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
