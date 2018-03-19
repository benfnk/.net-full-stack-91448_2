using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "This Course is going to be fun. Do you Agree? Of Course.";
            Console.WriteLine(str.WordCount());
        }
    }
}
