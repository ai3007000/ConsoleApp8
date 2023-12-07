using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /// <summary>
    /// Класс логера
    /// </summary>
    class Logger : ILogger
    {
        public Logger() { }
        /// <summary>
        /// Обработчик события
        /// </summary>
        /// <param name="message">Сообщение</param>
        void ILogger.Event(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
        }
        /// <summary>
        /// Обработчик ошибки
        /// </summary>
        /// <param name="ex">Исключение</param>
        void ILogger.Error(Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ex.Message);
        }
    }
}
