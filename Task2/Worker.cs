using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /// <summary>
    /// Класс воркер
    /// </summary>
    class Worker : IWorker
    {
        ILogger Logger { get; set; }
        public Worker(ILogger Logger)
        {
            this.Logger = Logger;
        }
        /// <summary>
        /// Основная работа калькулятора
        /// </summary>
        void IWorker.Work()
        {
            try
            {
                Logger.Event("Worker начал свою работу.");

                ICalculate calculate = new Calculate();

                Console.WriteLine("Введите первое слогаемое.");
                if (!double.TryParse(Console.ReadLine(), out var a)) throw new MyException("Невернный ввод первого слогаемого.");

                Console.WriteLine("Введите второе слогаемое.");
                if (!double.TryParse(Console.ReadLine(), out var b)) throw new MyException("Неверный ввод второго слогаемого.");

                Console.WriteLine($"Результат: {calculate.OperationPlus(a, b)}");
                Logger.Event("Worker завершил свою работу.");
            }
            catch(Exception ex)
            {
                Logger.Error(ex);
            }
        }
    }
}
