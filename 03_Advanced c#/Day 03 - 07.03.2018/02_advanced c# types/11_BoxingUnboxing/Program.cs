using System;

namespace BoxingUnboxing
{
    class Program
    {
        class Person
        {
            public string Name { get; set; }
        }

        static void Main(string[] args)
        {
            int x = 100;
            object obj = x;
            Console.WriteLine(((Person)obj).Name);
            x = 200;
            Console.WriteLine(((Person)obj).Name);
      

        }
    }
}
