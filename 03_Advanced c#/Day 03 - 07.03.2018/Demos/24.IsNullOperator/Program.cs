using System;

namespace _24.IsNullOperator
{
    class Program
    {
        public class Example
        {
            public int Omer { get; set; }
            public void DoSomething()
            {
                Console.WriteLine("Hi, my Name is Omer");
            }


        }

        static void Main(string[] args)
        {
            var truncateString = Truncate(null, 30);
            var truncateString2 = Truncate2(null, 30);

            Example a = null;
            a?.DoSomething();

            int? num = a?.Omer;
        }

        public static string Truncate(string value, int length)
        {
            string result = value;
            if (value != null) // Skip empty string check for elucidation
            {
                result = value.Substring(0, Math.Min(value.Length, length));
            }
            return result;
        }

        public static string Truncate2(string value, int length)
        {
            return value?.Substring(0, Math.Min(value.Length, length));
        }
    }
}
