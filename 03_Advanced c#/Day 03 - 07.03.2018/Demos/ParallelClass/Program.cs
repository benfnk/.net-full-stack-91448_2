using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ParallelClass
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Action t1 = new Action(() => Console.WriteLine("Hello world."));
            Action t2 = new Action(() => Console.WriteLine("Hello world 2."));
            Action t3 = new Action(() => Console.WriteLine("Hello world 3."));
            Action t4 = new Action(() => Console.WriteLine("Hello world 4."));
            Parallel.Invoke(t1, t2, t3, t4);

            List<int> lst = new List<int>()
            {
                1,
                2,
                3,
                4,
                5,
                6,
                7,
                100
            };

            //Parallel.ForEach(lst, (param) =>
            //{
            //    Console.WriteLine(param);
            //});

            Parallel.ForEach(lst, (item) => Console.WriteLine(item));
            
        }
    }
}
