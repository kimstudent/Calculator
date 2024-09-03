using System;

class Program
{
    static void Main()
    {
        bool continueCalculator = true;

        while (continueCalculator)
        {

            double num1 = Number("введите первое число");
            
            double num2 = Number("введите второе число");

            Console.WriteLine("Выберите (+, -, *, /):");
            string operation = Console.ReadLine();

            bool checkingOperation = true;
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = Add(num1, num2);
                    break;
                case "-":
                    result = Subtract(num1, num2);
                    break;
                case "*":
                    result = Multiply(num1, num2);
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = Divide(num1, num2);
                    }
                    else
                    {
                        Console.WriteLine("НОЛЬ");
                        checkingOperation = false;
                    }
                    break;
                default:
                    Console.WriteLine($"Введенное значение '{operation}' не корректно.");
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
    static double Add(double num1, double num2) { return num1 + num2; }
    static double Subtract(double num1, double num2) { return num1 - num2; }
    static double Multiply(double num1, double num2) { return num1 * num2; }
    static double Divide(double num1, double num2) { return num1 / num2; }

   
    static double Number(string hint)
    {
        double number;
        while (true)
        {
            Console.WriteLine(hint); 

            if (double.TryParse(Console.ReadLine(), out number)) 
            {
                return number; 
            }
            else
            {
                Console.WriteLine("не корректное число"); 
            }
        }
    }


}
