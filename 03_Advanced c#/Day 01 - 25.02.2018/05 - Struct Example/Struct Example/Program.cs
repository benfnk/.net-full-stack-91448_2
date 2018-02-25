using System;

namespace Struct_Example
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Time.message+Time.messageCounter);

            Time t1 = new Time(12, 23, 34);  //בניה של משתנה עם בנאי
            Console.WriteLine(t1); ;

            Console.WriteLine(Time.message + Time.messageCounter);

            Time t2=new Time();  //בניה של משתנה עם בנאי דיפולטיבי
            t2.Hour = 23;
            t2.Minute = 34;
            t2.Second = 45;
            t2.Display();


            Time t3;  //בניה של משתנה ללא בנאי

            //שגיאת קומפילציה - מכיוון שפנינו לפונקציה לפני שכל ערכי המשתנים אותחלו
            //Console.WriteLine(t3.ToString());  --> compilation error

            Console.WriteLine(Time.message + Time.messageCounter);
        }
    }
}


/*
*
*   output:
* 
* --------------------- 
I am static in struct 0
12:23:34
I am static in struct 1
23:34:45
I am static in struct 1    
*/
