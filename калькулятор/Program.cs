using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Простой калькулятор");
        Console.WriteLine("Введите первое число:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Выберите операцию (+, -, *, /):");
        char operation = Console.ReadLine()[0];

        double result;

        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                    result = num1 / num2;
                else
                {
                    Console.WriteLine("Ошибка: Деление на ноль.");
                    return;
                }
                break;
            default:
                Console.WriteLine("Ошибка: Неверная операция.");
                return;
        }

        Console.WriteLine($"Результат: {result}");
    }
}

