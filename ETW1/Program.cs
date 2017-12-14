using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ETW1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting application");
            var eventCounter = ETWLogger.Log;
            var random = new Random();
            for (int i = 0; i < 10_000; i++)
            {
                Thread.Sleep(random.Next(1, 500));
                eventCounter.CountChickens(random.Next(1, 5_000));
                Console.Write(".");
            }
            Console.WriteLine("Done.");
            Console.ReadLine();
        }
    }
}
