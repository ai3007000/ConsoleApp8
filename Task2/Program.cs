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

                IWorker worker = new Worker(Logger);
                worker.Work();
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}