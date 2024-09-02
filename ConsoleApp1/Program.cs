using System;

class Program
{
    static void Main()
    {
        bool continueCalculator = true;

        while (continueCalculator)
        {
            Console.WriteLine("Первое число");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Второе число");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Выберите (+, -, *, /):");
            string operation = Console.ReadLine();

            bool checkingOperation = true;
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
                        checkingOperation = false;
                    }
                    break;
                default:
                    Console.WriteLine("ОШИБКА");
                    checkingOperation = false;
                    break;
            }
            if (checkingOperation)
            {
                Console.WriteLine($"Результат: {result}");
            }
            Console.WriteLine("Продолжить?(да/нет)");
            string Response = Console.ReadLine();
            if (Response != "да")
            {
                continueCalculator = false;
            }
        }
        Console.WriteLine("Конец");
    }
}
