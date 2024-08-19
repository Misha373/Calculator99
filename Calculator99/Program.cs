Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Програма калькулятор");

Console.WriteLine("Введіть число a:");
double a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введіть число b:");
double b = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введіть операццію між числами a і b:");

char operation = Convert.ToChar(Console.ReadLine());




 if (operation == '/')
{
  if (b == 0)
    {
        Console.WriteLine("Вираз не має змісту");
    }
  else
    {
        Console.WriteLine($"Рішенням математичної задачі є: {a/b}");
    }
}
else if (operation == '*')
{
    Console.WriteLine($"Рішенням математичної задачі є: {a * b}");
}
 else if (operation == '-')
{
    Console.WriteLine($"Рішенням математичної задачі є: {a - b}");
}
else if (operation == '+')
{
    Console.WriteLine($"Рішенням математичної задачі є: {a + b}");
}
else if (operation == '^')
{
    Console.WriteLine($"Рішенням математичної задачі є: {Math.Pow(a,b)}");
}
else
{
    Console.WriteLine("Вираз не має змісту");
}

