int num;

while (true)
{
    Console.Write("Введите число от 1 до 7: ");
    if (int.TryParse(Console.ReadLine(), out num))
    {
        if (num > 0 && num < 8)
            break;
        else
            Console.WriteLine("В неделе 7 дней!");
    }
    else
        Console.WriteLine("Ошибка ввода!");
}

if (num > 0 && num < 6)
    Console.WriteLine($"{num} -> нет");
else if (num > 5 && num < 8)
    Console.WriteLine($"{num} -> да");