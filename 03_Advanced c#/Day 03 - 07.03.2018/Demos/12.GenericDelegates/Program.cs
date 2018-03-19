using System;

namespace _12.GenericDelegates
{
    public delegate void GenericAction<T>(T param);

    public delegate void GenericAction<T1, T2>(T1 param, T2 param2);

    public delegate R GenericFunction<R, T1> (T1 param);

    class Program
    {
        static void Main(string[] args)
        {
            GenericAction<string> printAction = (string str) => Console.WriteLine(str);
            printAction("This Course Is Amazing");

            GenericAction<string, int> printPersonAgeAction = (string personName, int age) => Console.WriteLine(personName + " Age:" + age);
            printPersonAgeAction("Omer", 23);

            GenericFunction<bool, int> isBiggerThan9 = (int age) => { return age > 9;};
            
        }
    }
}
