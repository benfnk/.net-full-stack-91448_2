using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(1, 2, 4, 5, 6));
            int[] numbers = new[]
            {
                1, 2,4,5,6
            };
            Console.WriteLine(Sum(numbers));

            UseParams(new int[2], "", 23.0, 22.0);
        }

        public static void UseParams(int[] numbers, string something, params double[] numbers2)
        {

        } 

        public static int Sum(params int [] numbers)
        {
            int sum = 0;

            foreach (int num in numbers)
            {
                sum += num;
            }

            return sum;
        }  

    }
}
