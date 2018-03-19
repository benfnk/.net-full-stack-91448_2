using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegates
{
    class Program
    {
        public delegate int MathOperation(int a, int b);

        public delegate void MyAction();
        public delegate void MyAction<T>(T parameter);
        public delegate void MyAction<T1, T2>(T1 parameter, T2 parameter2);

        public delegate T MyFunction<T>();
        public delegate T1 MyFunction<T1,T2>(T2 parameter);

        static void Main(string[] args)
        {
            MyAction action = () => Console.WriteLine("Action");
            action();
            MyAction<int> action2 = (num) => Console.WriteLine(num);
            action2(6);
            MyAction<DateTime> action3 = (date) => Console.WriteLine(date);
            action3(DateTime.Now);
            MyAction<int, DateTime> action4 = (num, date) =>
            {
                Console.WriteLine(date);
                Console.WriteLine(num);
            };
            action4(6,DateTime.Now);


            MyFunction<int> func= () => { return 3; };
            MyFunction<int, DateTime> func2 = (date) => { return 5; };

            Action act = new Action(() => Console.WriteLine("Nothing"));

            Func<DateTime> function = () => { return DateTime.Now; };
            Func<int, double> dunction2 = (num)=>{ return default(double); };
            Func<DateTime, double, int> func3 = (date, d) => { return default(int); };
            int a = func3(DateTime.Now, 7.0);

        }
    }
}
