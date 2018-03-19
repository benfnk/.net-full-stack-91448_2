using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Monitor
{
    public class GenericArray<T> : IEnumerable<T>
    {
        T[] m_array;

        int m_currentIndex = -1;

        public GenericArray(int size = 200)
        {
            m_array = new T[size];
        }

        public void Add(T obj)
        {
            lock (m_array)
            {
                m_currentIndex++;

                if (m_array.Count() > m_currentIndex)
                    m_array[m_currentIndex] = obj;
            }
            
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < m_currentIndex; i++)
            {
                yield return m_array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return m_array.GetEnumerator();
        }
    }



    class Program
    {
        static GenericArray<string> array = new GenericArray<string>();

        static void Main(string[] args)
        {
            List<Thread> lstThreads = new List<Thread>();

            for (int i = 0; i < 100; i++)
            {
                Thread th = new Thread(new ParameterizedThreadStart(AddElementToArray));
                th.Start(i);                
            }


            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

        }

        public static void AddElementToArray(object i)
        {
            array.Add(i.ToString() + "value");
        }
    }
}
