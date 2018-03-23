using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks
{
    class Program
    {
        async static void Main(string[] args)
        {
            Task<List<string>> t = new Task<List<string>>(() => 
            {

                List<String> lstStrings = new List<string>();

                for (int i = 0; i < 20; i++)
                {
                    Thread.Sleep(1000);
                    lstStrings.Add("Here");
                }

                return lstStrings;
            });

            t.Start();

            var index = 1;

            while(t.Status == TaskStatus.Running || t.Status == TaskStatus.WaitingToRun)
            {
                Console.Clear();
                Console.Write("Doing Something Else");
                for (int i = 0; i < index; i++)
                {
                    Console.Write(".");                    
                }

                Thread.Sleep(1000);

                index++;
                index =index % 4;
            }

            Console.WriteLine(t.Result);

            await t;
        }
    }
}
