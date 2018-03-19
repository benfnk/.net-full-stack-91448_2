using System;

namespace _4.Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic objDynamic = 4;
            objDynamic = "This Course Rocks";
            var arrSplit = objDynamic.Split(new char[] { ' ' });
            (arrSplit as string[]).PrintWords();


            //arrSplit.PrintWords();  ---> Runtime Error


            //Convertions
            dynamic d1 = 7;
            dynamic d2 = "a string";
            dynamic d3 = DateTime.Today;
            dynamic d4 = System.Diagnostics.Process.GetProcesses();

            int i = d1;
            string str = d2;
            DateTime dt = d3;
            System.Diagnostics.Process[] procs = d4;

            // Arithmetic

            dynamic d = 1;
            var testSum = d + 3;
            // Rest the mouse pointer over testSum in the following statement.
            System.Console.WriteLine(testSum);

            // Classes

            ExampleClass ec = new ExampleClass();
            // The following call to exampleMethod1 causes a compiler error 
            // if exampleMethod1 has only one parameter. Uncomment the line
            // to see the error.
            // ec.exampleMethod1(10, 4);

            dynamic dynamic_ec = new ExampleClass();
            // The following line is not identified as an error by the
            // compiler, but it causes a run-time exception.
            dynamic_ec.ExampleMethod1(10, 4);

            // The following calls also do not cause compiler errors, whether 
            // appropriate methods exist or not.
            dynamic_ec.SomeMethod("some argument", 7, null);
            dynamic_ec.NonexistentMethod();

            // Valid.
            ec.ExampleMethod2("a string");

            // The following statement does not cause a compiler error, even though ec is not
            // dynamic. A run-time exception is raised because the run-time type of d1 is int.
            ec.ExampleMethod2(d1);


            // The following statement does cause a compiler error.
            //ec.exampleMethod2(7);

        }
    }
    
}
