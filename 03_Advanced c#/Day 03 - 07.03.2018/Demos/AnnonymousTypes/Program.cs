using System;

namespace AnnonymousTypes
{
    public class Program
    {
        private class Example
        {
            public int Amount { get; set; }
            public string Message { get; set; }
        }

        static void Main(string[] args)
        {
            var named = new Example(){ Amount = 108, Message = "Hello" };
            var annonymous = new { Amount = 108, Message = "Hello" };
            var annonymous2 = new { Amount = 102, Message = "Hello2" };
            var annonymous3 = new { Amount = 102, Message = "Hello2", Body = "hello" };
            var annonymous4 = new { Amount = 102,
                Message = "Hello2",
                DoSomething = (Action<String>)((string str) => Console.WriteLine(str))
            };
            Console.WriteLine(named.GetType());
            Console.WriteLine(annonymous.GetType());
            Console.WriteLine(annonymous2.GetType());
            Console.WriteLine(annonymous4.GetType());
            Console.WriteLine(named.ToString());
            Console.WriteLine(annonymous4.ToString());
            annonymous = annonymous2;

            // Will not Compile
            //annonymous = annonymous3;


            // Rest the mouse pointer over v.Amount and v.Message in the following  
            // statement to verify that their inferred types are int and string.  
            Console.WriteLine(annonymous.Amount + annonymous.Message);

            // Will not compile
            //annonymous.Amount = 5;



        }
    }
}
