using System;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num = null;
            int? num = null;

            // Is the HasValue property true?
            if (num.HasValue)
            {
                Console.WriteLine("num = " + num.Value);
            }
            else
            {
                Console.WriteLine("num = Null");
            }

            // y is set to zero
            int y = num.GetValueOrDefault();
            int z = default(int);
            // num.Value throws an InvalidOperationException if num.HasValue is false
            try
            {
                y = num.Value;
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
