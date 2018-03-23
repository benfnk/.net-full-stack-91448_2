using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        public class Point 
        {
            public int X { get; set; }
            public int Y { get; set; }

            public override bool Equals(object obj)
            {
                // C# 7.0
                return obj is Point point && point.X == this.X && point.Y == this.Y;
            }

            public override int GetHashCode()
            {
                return (int)(Math.Pow(2, X) * Math.Pow(3,Y));
            }
        }


        static void Main(string[] args)
        {
            //List<int> numbers = new List<int>();

            // New Initializing
            Dictionary<Point, int> dic = new Dictionary<Point, int>()
            {
                [new Point()
                {
                    X = 1,
                    Y = 2
                }] = 42,
            };
            

            var value = dic[new Point()
            {
                X = 1,
                Y = 2
            }];

            // Old Initializing
            Dictionary<int, DateTime> items = new Dictionary<int, DateTime>()
            {
                {111, DateTime.Now }
            };
            //items.Add(111, DateTime.Now);

            //Stack<double> stack = new Stack<double>();
            //stack.Push(11.22);
            //Console.WriteLine(stack.Pop());

            //Queue<float> q = new Queue<float>();
            //q.Enqueue(11);
            //Console.WriteLine(q.Dequeue());

            //LinkedList<int> items = new LinkedList<int>();
            //items.AddFirst(11);
            //items.AddLast(22);
            //items.AddLast(33);
            //items.AddLast(44);
            //for (LinkedListNode<int> p = items.First; p != null; p = p.Next)
            //    Console.WriteLine(p.Value);

            //SortedList<string, int> items = new SortedList<string, int>();
            //items.Add("bb", 11);
            //items.Add("cc", 33);
            //items.Add("aa", 22);

            //foreach (var key in items.Keys)
            //    Console.WriteLine(key + " --> " + items[key]);

            
            //HashSet<int> items = new HashSet<int>();
            //items.Add(11);
            //items.Add(22);
            //items.Add(33);
            //items.Add(22);
            //foreach (var item in items)
            //    Console.WriteLine(item);

            //SortedSet < int > items = new SortedSet<int>();
            //Console.WriteLine(items.Add(33));
            //items.Add(11);
            //items.Add(22);
            //Console.WriteLine(items.Add(22));
            //foreach (var item in items)
            //    Console.WriteLine(item);

        }
    }
}
