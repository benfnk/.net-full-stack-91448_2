using System;
using System.Collections.Generic;
using System.Threading;

namespace _37.TLS
{
    class Program
    {
        [ThreadStatic] // Thread Local Storage
        static List<int> numbers = new List<int>();

        static void Add()
        {
            numbers = new List<int>(200000);
            for (int i = 0; i < 100000; i++)
                numbers.Add(i);
            Console.WriteLine(numbers.Count);
        }

        static void Main(string[] args)
        {
            Thread t = new Thread(Add);
            t.Start();
            Thread t2 = new Thread(Add);
            t2.Start();


            t2.Join();
            t.Join();
            numbers.Add(5);
            Console.WriteLine(numbers.Count);
        }
    }
}
