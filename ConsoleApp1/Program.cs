using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Первое число");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Второе число");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Выберите (+, -, *, /):");
        string operation = Console.ReadLine();

        double result = 0;

        switch (operation)
        {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("НОЛЬ");
                    return;
                }
                break;
            default:
                Console.WriteLine("ОШИБКА");
                return;
        }

        Console.WriteLine($"Результат: {result}");
    
        Console.ReadKey();
    }

}
