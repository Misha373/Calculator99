Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Програма калькулятор");

Console.WriteLine("Введіть число a:");
double a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введіть число b:");
double b = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введіть операццію між числами a і b:");

string? operation = Convert.ToString(Console.ReadLine());


switch(operation)
{
    case "/":
        switch(b)
        {
            case 0:
                Console.WriteLine("Вираз не має змісту");
                break;
            default:
                Console.WriteLine($"Рішенням математичної задачі є: {a / b}");
                break;
        }
        break;
    case "*":
        Console.WriteLine($"Рішенням математичної задачі є: {a * b}");
        break;
    case "+":
        Console.WriteLine($"Рішенням математичної задачі є: {a + b}");
        break;
    case "-":
        Console.WriteLine($"Рішенням математичної задачі є: {a - b}");
        break;
    case "^":
        Console.WriteLine($"Рішенням математичної задачі є: {a * b}");
        break;
    default:
        Console.WriteLine("Вираз не має змісту");
        break;
}