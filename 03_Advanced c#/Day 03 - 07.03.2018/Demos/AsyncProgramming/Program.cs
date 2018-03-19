using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AsyncProgramming
{
    class Program
    {
        //static  AutoResetEvent rest = new AutoResetEvent(false);

        static int color = 1;
        static async void GetUrlAsync(string url)
        {
            HttpClient client = new HttpClient();
            Task<string> t = client.GetStringAsync(url);
            string html = await t;
            Console.ForegroundColor = (ConsoleColor)(color++);
            Console.WriteLine(html);
            Console.ResetColor();

            //rest.Set();
        }

        static void Download()
        {
            string[] arr = new string[] {
                "http://www.yahoo.com",
                "http://www.google.com",
                "http://www.walla.co.il",
                "http://www.nana.co.il"
            };

            for (int i = 0; i < arr.Length; i++)
            {
                GetUrlAsync(arr[i]);
            }
        }

        static void Main(string[] args)
        {
            Download();
            Console.WriteLine("End of main...");

            //WaitHandle.WaitAll(new WaitHandle[] { rest });

            //Console.ReadLine();
        }
    }
}
