using System;

namespace _4.Dynamic
{
    public static class MyExtensions
    {
        public static void PrintWords(this Array args)
        {
            foreach (var item in args)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
