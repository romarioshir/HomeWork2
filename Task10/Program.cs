Console.Clear();

int EnterNumber()
{
    int num;

    while (true)
    {
        Console.Write("Введите целое трёхзначное число: ");
        if (int.TryParse(Console.ReadLine(), out num))
        {
            if (num >= 100 && num <= 999)  // или if (num / 100 > 0 && num / 1000 == 0)
                break;
            else
                Console.WriteLine("Ошибка ввода!");
        }
        else
            Console.WriteLine("Ошибка ввода!");
    }
    return num;
}

int a = EnterNumber();

int SecondNumber = (a % 100) / 10;

Console.WriteLine($"{a} -> {SecondNumber}");