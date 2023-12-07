using System;

namespace Task2
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                ILogger Logger = new Logger();

                var worker = new Worker(Logger);
                ((IWorker)worker).Work();
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}