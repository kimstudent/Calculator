using System;
public interface IOperation 
{
    double Execute(double num1, double num2);
}

public class Addition : IOperation
{
    public double Execute(double num1, double num2)
    {
        return num1 + num2; 
    }
}
public class Subtraction : IOperation
{
    public double Execute(double num1, double num2)
    {
        return num1 - num2;
    }
}
public class Multiplication : IOperation
{
    public double Execute(double num1, double num2)
    {
        return num1 * num2;
    }
}
public class Division : IOperation
{
    public double Execute(double num1, double num2)
    {
        if (num2 == 0 )
        {
            Console.WriteLine("На ноль делить нельзя");
        }
        return num1 / num2;
    }
}

public class Calculator
{
    public double Calculate(IOperation operation, double num1, double num2)
    {
        return operation.Execute(num1, num2);
    }
}

class Program
{
    static void Main()
    {
        
        Calculator calculator = new Calculator();
        bool continueCalculator = true;

        while (continueCalculator)
        {
            Console.WriteLine("Выберите операцию: +, -, *, /");
            string pick = Console.ReadLine();

            if(pick == "5")
            {
                continueCalculator = false;
                break;
            }

            Console.WriteLine("Введите первое число:");
            double num1;
            if(!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Некорректный ввод");
                continue;
            }

            Console.WriteLine("Введите первое число:");
            double num2;
            if (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Некорректный ввод");
                continue;
            }

            bool checkingOperation = true;
            IOperation operation = null;


            switch (pick)
            {
                case "+":
                    operation = new Addition();
                    break;
                case "-":
                    operation = new Subtraction();
                    break;
                case "*":
                    operation = new Multiplication();
                    break;
                case "/":
                    operation = new Division();
                    break;
                default:
                    Console.WriteLine($"Введенное значение '{operation}' не корректно.");
                    checkingOperation = false;
                    break;
            }
            if (checkingOperation)
            {
                double result = calculator.Calculate(operation, num1, num2);
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
