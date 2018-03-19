using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ConcurrentCollections
{
    class Program
    {
        //static Dictionary<string, string> dic = new Dictionary<string, string>();

        static ConcurrentDictionary<string, string> dic = new ConcurrentDictionary<string, string>();
       

        static void Main(string[] args)
        {
            object obj = new object();

            Monitor.Wait(obj);

            int a = 7;

            Monitor.Exit(obj);


            List<string> lst = new List<string>();

            for (int i = 0; i < 100000000; i++)
            {
                lst.Add("Hello" + i);
            }

            Parallel.ForEach(lst, (str) =>
             {
                 if (!dic.TryAdd(str, str))
                 {
                     Console.WriteLine("fhdkjfid");
                 };
             });
        }
    }
}
