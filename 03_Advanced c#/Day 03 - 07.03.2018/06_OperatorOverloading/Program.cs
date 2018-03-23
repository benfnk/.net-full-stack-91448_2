using System;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex num1 = new Complex(2, 3);
            Complex num2 = "3 +4i";

            // Add two Complex objects (num1 and num2) through the
            // overloaded plus operator:
            Complex sum = num1 + num2;

            // Print the numbers and the sum using the overriden ToString method:
            Console.WriteLine("First complex number:  {0}", num1);
            Console.WriteLine("Second complex number: {0}", num2);
            Console.WriteLine("The sum of the two numbers: {0}", sum);
        }
    }
}
