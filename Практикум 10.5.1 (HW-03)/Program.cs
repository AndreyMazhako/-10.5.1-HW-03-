using System;

namespace Практикум_10._5._1__HW_03;

class Program
{
    static void Main(string[] args)
    {
        IAdder adder = new Adder(); // Создаем экземпляр класса, реализующего интерфейс

        Console.WriteLine("Введите первое число:");
        double num1;
        if (!TryParseDouble(Console.ReadLine(), out num1)) return;


        Console.WriteLine("Введите второе число:");
        double num2;
        if (!TryParseDouble(Console.ReadLine(), out num2)) return;

        try
        {
            double sum = adder.Add(num1, num2);
            Console.WriteLine($"Сумма: {sum}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Выполнение завершено.");
        }

        Console.ReadKey();
    }

    // Вспомогательная функция для безопасного парсинга double
    static bool TryParseDouble(string input, out double result)
    {
        if (double.TryParse(input, out result))
        {
            return true;
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Введите число.");
            return false;
        }
    }
}