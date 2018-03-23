using System;
using System.Threading;

namespace GCExample
{
    class Person
    {
        public string FullName { get; set; }

        ~Person()
        {
            Console.WriteLine("dtor...");
        }
    }

    class Program
    {
        private const int maxGarbage = 1000;

        static void Main()
        {
            // Put some objects in memory.
            MakeSomeGarbage();
            Console.WriteLine("Memory used before collection:       {0:N0}",
                              GC.GetTotalMemory(false));

            Thread.Sleep(1000);

            Console.WriteLine("Memory used before collection:       {0:N0}",
                              GC.GetTotalMemory(false));

            // Collect all generations of memory.
            GC.Collect();
            Console.WriteLine("Memory used after full collection:   {0:N0}",
                              GC.GetTotalMemory(true));
        }

        static void MakeSomeGarbage()
        {
            Person vt;

            // Create objects and release them to fill up memory with unused objects.
            for (int i = 0; i < maxGarbage; i++)
            {
                vt = new Person();               
            }
        }
    }
}
