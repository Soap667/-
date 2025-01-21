using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Усовершенствованный калькулятор");
        List<string> history = new List<string>();

        while (true)
        {
            Console.WriteLine("\nВыберите операцию:");
            Console.WriteLine("1. Сложение (+)");
            Console.WriteLine("2. Вычитание (-)");
            Console.WriteLine("3. Умножение (*)");
            Console.WriteLine("4. Деление (/)");
            Console.WriteLine("5. Возведение в степень (^)");
            Console.WriteLine("6. Модуль (%)");
            Console.WriteLine("7. Квадратный корень (sqrt)");
            Console.WriteLine("8. Просмотреть историю");
            Console.WriteLine("9. Очистить историю");
            Console.WriteLine("0. Выход");

            Console.Write("Ваш выбор: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 0)
                break;

            double num1, num2 = 0, result;
            string operation;

            switch (choice)
            {
                case 1:
                    operation = "+";
                    break;
                case 2:
                    operation = "-";
                    break;
                case 3:
                    operation = "*";
                    break;
                case 4:
                    operation = "/";
                    break;
                case 5:
                    operation = "^";
                    break;
                case 6:
                    operation = "%";
                    break;
                case 7:
                    operation = "sqrt";
                    break;
                case 8:
                    Console.WriteLine("\nИстория операций:");
                    foreach (string entry in history)
                        Console.WriteLine(entry);
                    continue;
                case 9:
                    history.Clear();
                    Console.WriteLine("История очищена.");
                    continue;
                default:
                    Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                    continue;
            }

            Console.Write("Введите первое число: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            if (operation != "sqrt")
            {
                Console.Write("Введите второе число: ");
                num2 = Convert.ToDouble(Console.ReadLine());
            }

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
                        result = num1 / num2;
                    else
                    {
                        Console.WriteLine("Ошибка: Деление на ноль.");
                        continue;
                    }
                    break;
                case "^":
                    result = Math.Pow(num1, num2);
                    break;
                case "%":
                    result = num1 % num2;
                    break;
                case "sqrt":
                    if (num1 >= 0)
                        result = Math.Sqrt(num1);
                    else
                    {
                        Console.WriteLine("Ошибка: Отрицательное число.");
                        continue;
                    }
                    break;
                default:
                    Console.WriteLine("Неизвестная операция.");
                    continue;
            }

            string resultString = $"{num1} {operation} {num2} = {result}";
            Console.WriteLine(resultString);
            history.Add(resultString);
        }
    }
}
