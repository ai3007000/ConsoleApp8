using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Task1
{
    /// <summary>
    /// Интерфейс калькулятора
    /// </summary>
    interface ICalculate
    {
        double OperationPlus(double a, double b);
        double OperationMinus(double a, double b);
    }
}
