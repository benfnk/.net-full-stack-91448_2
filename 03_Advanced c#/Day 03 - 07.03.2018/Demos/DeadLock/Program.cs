using System.Threading;

namespace DeadLock
{
    class Program
    {
        public static object resourceA = new object();
        public static object resourceB = new object();

        static void Main(string[] args)
        {
            Thread th1 = new Thread(Thread1);
            Thread th2 = new Thread(Thread2);

            th1.Start();
            th2.Start();

            th1.Join();
            th2.Join();
        }

        public static void Thread1()
        {
            lock (resourceA)
            {
                Thread.Sleep(50);
                lock (resourceB)
                {
                    Thread.Sleep(50);
                }
            }
        }

        public static void Thread2()
        {
            lock(resourceB)
            {
                Thread.Sleep(50);
                lock(resourceA)
                {
                    Thread.Sleep(50);
                }
            }
        }



    }
}
