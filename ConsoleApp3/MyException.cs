using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    /// <summary>
    /// Моё исключение
    /// </summary>
    class MyException : Exception
    {
        public MyException() { }
        public MyException(string message) : base(message) { }
    }
}
