using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 10; //explicitly typed  
            var i = 10; // implicitly typed  

            // Cannot compile- diffrent type.
            //i = "ss";
            // Cannot compile / unknown type.
            //var d;

            // Example #1: var is optional because
            // the select clause specifies a string
            string[] words = { "apple", "strawberry", "grape", "peach", "banana" };
            var wordQuery = from word in words
                            where word[0] == 'g'
                            select word;

            // var is optional here also.
            foreach (string s in wordQuery)
            {
                Console.WriteLine(s);
            }

            foreach (var s in wordQuery)
            {
                Console.WriteLine(s);
            }



        }
    }
}
