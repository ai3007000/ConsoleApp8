using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /// <summary>
    /// Класс калькулятора
    /// </summary>
    class Calculate : ICalculate
    {
        /// <summary>
        /// Операция сложения
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Результат</returns>
        double ICalculate.OperationPlus(double a, double b)
        {
            return a + b;
        }
        /// <summary>
        /// Операция вычитания
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Результат</returns>
        double ICalculate.OperationMinus(double a, double b)
        {
            return a - b;
        }
    }
}
