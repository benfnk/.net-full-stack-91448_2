using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic dyn = "Omer";            
            var splits = dyn.Split('m');
            string notdym = "Omer";            

            foreach (var item in splits)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(dyn);
            Console.WriteLine(dyn.GetType());
            dyn = 3;
            Console.WriteLine(dyn);
            Console.WriteLine(dyn.GetType());
            dyn = Process.GetProcesses();
            Console.WriteLine(dyn);
            Console.WriteLine(dyn.GetType());
        }
    }
}
