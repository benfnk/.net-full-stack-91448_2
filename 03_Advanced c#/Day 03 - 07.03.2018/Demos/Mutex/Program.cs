using System.Threading;

namespace Mutex
{
    public class A
    {
        private object mutex = new object();
        public void F()
        {
            
            lock (mutex)
            {
                Thread.Sleep(100);
            }            
        }
        public void G()
        {
            lock (mutex)
            {
                Thread.Sleep(100);
                F();
            }           
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            // create method and pass content within it and search it in google 
            Thread a = new Thread((new A()).G);
            a.Start();
        }
    }
}
