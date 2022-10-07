double EnterNumber()
{
    double num;

    while (true)
    {
        Console.Write("Введите целое число: ");

        if (double.TryParse(Console.ReadLine(), out num))
            break;

        else
            Console.WriteLine("Ошибка ввода!");
    }
    return num;
}

double a = EnterNumber();

if (a < 100 && a > -99)
{
    Console.WriteLine($"{a} -> Третьей цифры нет");
}
// отсюда я долго ломал голову. не знаю как найти третью цифру в числе, если число может быть бесконечным.
else if (a > 99)
{
    string text = a.ToString();
    Console.WriteLine($"{a} ->  {text[2]}");
}
