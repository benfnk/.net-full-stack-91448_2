using System;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int result1 = MulNumbers(4, 3);
            Console.WriteLine(result1);


            int result2 = PowNumbers(3, 3);
            Console.WriteLine(result2);
        }

        static int MulNumbers(int a, int b)
        {
            if (b != 0)
            {

                int tempRes = a + MulNumbers(a, b - 1);
                Console.WriteLine("temp res is: "+tempRes);
                return tempRes;
            }
            return 0;
        }


        static int PowNumbers(int a, int b)
        {
            if (b != 0)
            {
                return a * MulNumbers(a, b - 1);
            }
            return 1;
        }
    }
}
