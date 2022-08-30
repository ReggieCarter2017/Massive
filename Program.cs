int numbers = new Random().Next(1, 10000);
int count = numbers.ToString().Length;
    if (count >= 3)
    Console.Write($"{numbers} -> {numbers.ToString()[index: 2]}");
    else
    Console.Write("Третьей цифры нет!");
