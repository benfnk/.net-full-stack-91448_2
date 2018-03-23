using System;

namespace Mutex
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mutex - can lock threads over several processes.
            System.Threading.Mutex mutex = new System.Threading.Mutex(false, "Omer"); // Omer = Mutex shared name among processes.

            Console.WriteLine("Press Enter for Locking");
            Console.ReadLine();
            mutex.WaitOne();

            Console.WriteLine("Press Enter for Releasing");
            Console.ReadLine();
            mutex.ReleaseMutex();

            Console.WriteLine("Mutex Released.");
            Console.ReadLine();
        }
    }
}
