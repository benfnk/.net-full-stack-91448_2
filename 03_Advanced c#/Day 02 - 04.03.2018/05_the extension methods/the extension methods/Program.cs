using System;

namespace the_extension_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "4";


            //not extension_method - called as regular function
            int y1 = MyClass.ToInt1(x);


            //extension_method - called with the object that we extented
            int y2 = x.ToInt();
            y2.ToBiggerInt();

            Console.WriteLine(y2);
            x.SayMagenta(y1);
        }       
    }

    static class MyClass
    {

        public static int ToInt1(string str)
        {
            return int.Parse(str);
        }


        //string הרחבה לכל אובייקט מסוג
        public static int ToBiggerInt(this int num)
        {
            return num++;
        }


        //string הרחבה לכל אובייקט מסוג
        public static int ToInt(this string str)
        {
            return int.Parse(str);
        }


        //string הרחבה לכל אובייקט מסוג
        public static void SayMagenta(this string st, int num)
        {
            Console.WriteLine(st + " Magenta");
        }
    }
}
