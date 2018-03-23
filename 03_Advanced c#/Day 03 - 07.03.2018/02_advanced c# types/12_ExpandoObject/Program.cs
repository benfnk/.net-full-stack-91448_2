using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;

namespace ExpandoObject
{
    class Program
    {
        delegate void Action<T1,T2,T3>(T1 gf, T2 nb , T3 mj);

        static void Main(string[] args)
        {


            dynamic sampleObject = new System.Dynamic.ExpandoObject();

            sampleObject.MyName = "Omer";
            sampleObject.myMethod = (Action)(() => Console.WriteLine("Omer"));
            sampleObject.myFunc = (Func<dynamic, bool>)((dynamic c) => {
                if (c != null)
                    return true;
                else return false;
            });
            Console.WriteLine(sampleObject.MyName);
            sampleObject.myMethod();
            Console.WriteLine(sampleObject.myFunc(null));
        }
    }
}
