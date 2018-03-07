using System;

namespace generic_function
{
    struct Cat
    {
        string age;
    }
    
    class Program
    {
        static void Main(string[] args)
        {

          
            Cat cat1 = new Cat();
            Cat cat2 = new Cat();

            //Operator '==' cannot be applied to operands of type 'Cat' and 'Cat' 
            //Console.WriteLine(cat1 == cat2); --> COMPILATION ERROR


            //'Cat' does not contain a definition for 'CompareTo' and no extension method
            //cat1.CompareTo(cat2);  --> COMPILATION ERROR



            //The type 'generic_function.Cat' cannot be used as type parameter 'T' 
            //in the generic type or method 'Program.MaxGeneric<T>(T, T)'.
            //There is no boxing conversion from 'generic_function.Cat' to 'System.IComparable'

            //Console.WriteLine(MaxGeneric<Cat>(cat1, cat2)); --> COMPILATION ERROR


            int num1 = 1, num2 = 2;
            string str1 = "A", str2 = "B";

       
            Console.WriteLine(Max(num1, num2));
            Console.WriteLine(Max(str1, str2));
            

            Console.WriteLine(MaxGeneric<int>(num1, num2));
            Console.WriteLine(MaxGeneric<string>(str1, str2));
        }

        //---------------------------------------------------------------
        //אותה פונקציה בדיוק - עם אותו תוכן - אך עם טיפוס משתנה אחר
        static int Max(int a, int b)
        {
            return (a.CompareTo(b) > 0) ? a : b;
        }

        static string Max(string a, string b)
        {
            return (a.CompareTo(b) > 0) ? a : b;
        }
        //---------------------------------------------------------------


        //IComparable רק משתנים מטיפוס שמממש את
        //יוכל להגדיר את הסוג של הגנריות 
        static T MaxGeneric<T>(T a, T b) where T :IComparable
        {
            return (a.CompareTo(b)>0)? a:b;
        }

        
    }
}
