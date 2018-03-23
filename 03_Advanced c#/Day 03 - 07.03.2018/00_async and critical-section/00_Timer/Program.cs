using System;
using System.Timers;

namespace Timers
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Timers.Timer obj = new System.Timers.Timer(2000);
            obj.Elapsed += Obj_Elapsed;
            obj.Start();

            while(true)
            {
                
            }

        }

        private static void Obj_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Two Seconds have passed");
        }
    }
}
