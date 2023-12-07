using System;

namespace ConsoleApp3.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ICalculate calculate = new Calculate();

                Console.WriteLine("Введите первое слогаемое.");
                if (!double.TryParse(Console.ReadLine(), out var a)) throw new MyException("Невернный ввод первого слогаемого.");

                Console.WriteLine("Введите второе слогаемое.");
                if (!double.TryParse(Console.ReadLine(), out var b)) throw new MyException("Неверный ввод второго слогаемого.");

                Console.WriteLine($"Результат: {calculate.OperationPlus(a, b)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}