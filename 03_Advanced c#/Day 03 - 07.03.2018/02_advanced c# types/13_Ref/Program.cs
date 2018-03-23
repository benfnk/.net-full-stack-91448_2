using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = null;
            DoSomething(str);
            Console.WriteLine(str);

            List<int> lst = new List<int>();
            lst.Add(1);

            DoSomething2(ref lst);



            if(lst.Count > 0)
            {
                Console.WriteLine("Bigger than 0");
            }
            else
            {
                Console.WriteLine("0");
            }

        }

        public static void DoSomething(string str)
        {
            str = "Hello World";
        }


        public static void DoSomething2(ref List<int> p_lst)
        {
            p_lst = new List<int>();
        }

        public static void DoSomething3(List<int> p_lst)
        {
            p_lst.Remove(1);
        }

    }
}
