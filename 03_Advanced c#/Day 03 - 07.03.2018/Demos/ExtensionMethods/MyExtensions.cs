using System;

namespace ExtensionMethods
{

    public static class MyExtensions
    {
        public static int WordCount(this String str)
        {
            string[] a = str.Split(new char[] { ' ', '.', '?' });

            return str.Split(new char[] { ' ', '.', '?' },
                                StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
    
}
