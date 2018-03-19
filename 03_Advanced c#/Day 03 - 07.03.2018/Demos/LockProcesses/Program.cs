using System;

namespace LockProcesses
{
    class Program
    {
        static void Main(string[] args)
        {
            object s = new object();

            Console.WriteLine("Press Enter for Locking");
            Console.ReadLine();
            lock (s)
            {
                Console.WriteLine("Press Enter for Releasing");
                Console.ReadLine();                
            }

            Console.WriteLine("Released");
        }
    }
}
