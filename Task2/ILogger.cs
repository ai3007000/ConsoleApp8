using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /// <summary>
    /// Интерфейс логгера
    /// </summary>
    interface ILogger
    {
        void Event(string message);
        void Error(Exception ex);
    }
}
