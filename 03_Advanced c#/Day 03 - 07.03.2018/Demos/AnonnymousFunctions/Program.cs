using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonnymousFunctions
{
    class Program
    {
        delegate int MathOperator(int num1, int num2);



        static void Main(string[] args)
        {
            //MathOperator MethodPointer = new MathOperator(Add);
            //Console.WriteLine(MethodPointer(5, 7));

            //MathOperator MethodPointer2 = new MathOperator((num1, num2) => { return num1 + num2; });            
            //Console.WriteLine(MethodPointer2(5, 7));

            //MathOperator MethodPointer3 = (num1, num2) => { return num1 + num2; };
            //Console.WriteLine(MethodPointer3(5, 7));

            MathOperator op = Add;
            op += Sub;
            Console.WriteLine(op(12, 5)); 

            //var array = new string[]
            //{
            //    "omer", "meital", "matan"
            //};

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}

            //var list = array.ToList();
            //list.ForEach(x => x.Replace('e', 'f'));            
        }
        
        public static int Add(int num1, int secondnum)
        {
            Console.WriteLine(num1 + secondnum);
            return num1 + secondnum;
        }

        public static int Sub(int num1, int secondnum)
        {
            Console.WriteLine(num1 - secondnum);
            return num1 - secondnum;
        }


    }
}
