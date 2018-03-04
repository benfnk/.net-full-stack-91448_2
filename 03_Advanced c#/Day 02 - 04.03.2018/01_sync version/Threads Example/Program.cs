using System;
using System.Threading;

namespace Threads_Example
{
    class Program
    {
        static void Print1(object limit)
        {
            Console.WriteLine("\nPrint1 ThreadID: " + 
                Thread.CurrentThread.ManagedThreadId);

            int num;

        // Summary:
        //     Converts the string representation of a number to its 32-bit signed integer equivalent.
        //     A return value indicates whether the conversion succeeded.
        //
            int.TryParse(limit.ToString(), out num);

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Print1 - iteration number {i}");
                Thread.Sleep(5000); // Delay to current thread- milliseconds
            }
        }

        static void Print2()
        {
            Console.WriteLine("\nPrint2 ThreadID: " + Thread.CurrentThread.ManagedThreadId);

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"Print2 - iteration number {i}");
                Thread.Sleep(5000); // Delay to current thread- milliseconds

            }
        }


        //Main is the "Main thread" by default
        static void Main(string[] args) // The Main Thread
        {

            Console.WriteLine("Main ThreadID: " + Thread.CurrentThread.ManagedThreadId);

            Print1(3); // Sync Call - קריאה סינכרונית
            Print2(); // Sync Call - קריאה סינכרונית


            Console.WriteLine("End of Main");
        }
    }
}
