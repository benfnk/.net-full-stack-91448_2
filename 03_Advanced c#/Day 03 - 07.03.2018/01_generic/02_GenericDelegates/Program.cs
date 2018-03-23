using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegates2
{   
    class Program
    {
        static void Main(string[] args)
        {
            Func<double, DateTime, int> pointer = DoSomething;
            pointer(27.0, DateTime.Now);

            Func<double, DateTime, double> pointer3 = DoSomething3;

            Action action = DoSomething4;
            action();

            Action<Point> pointer2 = DoSomething2;
            pointer2(new Point() { X = 1, Y=2 });

            Action<Point, double, float> pointer5 = DoSomething5;
            pointer5(new Point() { X = 1, Y = 2 }, 43.0, 0.2f);
        }

        public static int DoSomething(double d, DateTime time)
        {
            return default(int);
        }

        public static double DoSomething3(double d, DateTime time)
        {
            return default(int);
        }

        public static void DoSomething2(Point p)
        {
            Console.WriteLine(p);
        }

        public static void DoSomething5(Point p, double c, float g)
        {
            Console.WriteLine(p);
        }

        public static void DoSomething4()
        {
            Console.WriteLine("Omer");
        }

    }

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

}
