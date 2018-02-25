using System;

namespace Enum_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Gray;  //שינוי צבע הרקע של מסך הפלט
            Console.ForegroundColor = ConsoleColor.Black;   //שינוי צבע הרקע של טקסט הפלט
            Console.Clear();

            Color c1 = Color.Green;
            Console.WriteLine(c1);
            Console.WriteLine((int)c1);

            int[] array = { 12, 34, 23, 67, 45, 23 };

          
            
            PrintArray(array, PrintStyle.Space);
            PrintArray(array, PrintStyle.Tab);
            PrintArray(array, PrintStyle.Enter);
            PrintArray(array, PrintStyle.Space | PrintStyle.Tab | PrintStyle.Enter);


        }

        // השיטה הנכונה
        static void PrintArray(int[] arr, PrintStyle printStyle)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                switch (printStyle)
                {
                    case PrintStyle.Space: Console.Write(arr[i] + " "); break;
                    case PrintStyle.Tab: Console.Write(arr[i] + "\t"); break;
                    case PrintStyle.Enter: Console.WriteLine(arr[i]); break;
                }
            }

            Console.WriteLine();
        }


    }
}
