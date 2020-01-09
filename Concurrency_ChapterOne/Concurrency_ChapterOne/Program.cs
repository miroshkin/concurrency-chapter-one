using System;
using System.Threading;

namespace Concurrency_ChapterOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Concurrency - Chapter One!");
            
            Thread thread = new Thread(PrintNumbersWithDelay);
            thread.Start();

            PrintNumbers();
        }

        static void PrintNumbers()
        {
            Console.WriteLine("Starting...");
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void PrintNumbersWithDelay()
        {
            Console.WriteLine("Starting...");
            for (int i = 1; i < 10; i++)
            {
                Thread.Sleep(TimeSpan.FromSeconds(1));
                Console.WriteLine(i);
            }
        }
    }
}
