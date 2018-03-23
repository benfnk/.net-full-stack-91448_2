using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        public static void Swap<T>(List<T> list1, List<T> list2)
        {
            //code to swap items
        }

        public static void Swap(List<int> list1, List<int> list2)
        {
            //code to swap items
        }


        static void Main(string[] args)
        {
            // int is the type argument
            GenericList<int> list = new GenericList<int>();

            for (int x = 0; x < 10; x++)
            {
                list.AddHead(x);
            }

            // Will Not Compile
            //list.AddHead("omer");

            foreach (int i in list)
            {
                System.Console.Write(i + " ");
            }

            System.Console.WriteLine("\nDone");

            SMS<string, DateTime> sms1 = new SMS<string, DateTime>();
            sms1.Subject = "Hi";
            sms1.Message = DateTime.Now;
            sms1.Send("052-9856987");            
        }
    }
}
