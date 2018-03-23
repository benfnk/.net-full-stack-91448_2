using System;
using System.Threading;

namespace Semaphores
{
    class Program
    {
        static Semaphore _mySemaphore;

        static void Print(object obj)
        {
            _mySemaphore.WaitOne();

            for (int i = 0; i < 10; i++)
            {
                Console.Write(obj + " ");
                Thread.Sleep(1000);
            }

            _mySemaphore.Release();
        }

        static void Main(string[] args)
        {
            // First number is the initial number of threads allowed to enter the resource,
            // Second number is the maximum number of threads allowed to enter the resource:
            int initialThreadsAllowed = 1; // Release -ים שיש להם אישור להתחיל לעבוד מיידית, ללא קשר לקריאה ל-Thread מספר ה
            int maximumThreadsAllowed = 3; // ם המקסימלים המותרים לריצה-Thread -מספר ה
            _mySemaphore = new Semaphore(initialThreadsAllowed, maximumThreadsAllowed);

            for (int i = 1; i <= 6; i++)
            {
                Thread t = new Thread(Print);
                t.Start(i);
            }

            Console.WriteLine("There are threads waiting to run.\nPress any key for allowing only {0} threads to run concurrently...", maximumThreadsAllowed);
            Console.ReadLine();

            // Releasing all the allowed threads, so the Semaphore could allow maximum number of threads to get access to a resource:
            _mySemaphore.Release(maximumThreadsAllowed - initialThreadsAllowed);
            //_mySemaphore.Release(10);
            // ים שמאושרים לרוץ במקביל-Thread -שחרור מספר ה
            // The total maximum threads that could run in parallel, will be maximumThreadsAllowd.
            // Thus releasing only the difference between the maximum and the initial, because the initials are already running.
        }
    }
}
