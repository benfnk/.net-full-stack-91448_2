using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string MyString = "My name is omer and i want to learn C#!";

            
            Console.WriteLine(MyString.EncryptLetters(3,5));
            //DecryptLetters(ref MyString, 3,5);
            Console.WriteLine(MyString.EncryptLetters(3, 5).DecryptLetters(3, 5));

            Console.WriteLine(MyString.Encrypt());
            Console.WriteLine(MyString.Encrypt().Decrypt());
        }

        public static void EncryptLetters(ref string str, params int[] p_Indexes)
        {
            StringBuilder strBuilder = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                bool IsDivided = false;
                p_Indexes.ToList().ForEach(index => IsDivided = (IsDivided || 
                i % index == 0));

                if (IsDivided)
                    strBuilder.Append(Convert.ToChar(Convert.ToInt32(str[i]) + 1));
                else
                    strBuilder.Append(str[i]);
            }

            str = strBuilder.ToString();

        }

        public static void DecryptLetters(ref string str, params int[] p_Indexes)
        {
            StringBuilder strBuilder = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                bool IsDivided = false;
                p_Indexes.ToList().ForEach(index => IsDivided = (IsDivided ||
                i % index == 0));

                if (IsDivided)
                    strBuilder.Append(Convert.ToChar(Convert.ToInt32(str[i]) - 1));
                else
                    strBuilder.Append(str[i]);
            }

            str = strBuilder.ToString();

        }
    }
}
