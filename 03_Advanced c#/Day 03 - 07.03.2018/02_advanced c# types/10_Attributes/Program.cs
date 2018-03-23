using System;
using System.Diagnostics;

namespace Attributes
{
    [Flags]
    enum Weather
    {
        Sunny = 1,
        Cloudy = 2,
        Rainy = 4,
        Foggy = 8,
        Snowy = 16
    }

    class Program
    {
        [Conditional("Testing1")]
        static void Print()
        {
            Console.WriteLine("Print...");
        }
        [Conditional("DEBUG")]

        static void Print2()
        {
            Console.WriteLine("Print 2...");
        }

        //static void Func([ParamArray] int x)
        //{
        //}

        [Obsolete("This function is obsolete... Use Fun3 instead...")]
        static void Func2()
        {
        }



        static void Main(string[] args)
        {
            Type t = typeof(Car);
            object[] arr = t.GetCustomAttributes(true);
            foreach (Attribute item in arr)
            {
                if (item is ProgrammerInfoAttribute)
                {
                    Console.WriteLine((item as ProgrammerInfoAttribute).ProgrammerName)
                        ;
                    Console.WriteLine((item as ProgrammerInfoAttribute).ProgrammingDate);
                }
            }


            Weather w = Weather.Sunny | Weather.Cloudy;
            Console.WriteLine(w);

            Print();
            Print2();

            Func2();

            //WebBrowser wb = new WebBrowser();
            //wb.DrawTo
        }
    }
}
