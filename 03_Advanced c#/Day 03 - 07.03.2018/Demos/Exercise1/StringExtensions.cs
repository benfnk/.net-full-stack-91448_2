using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public delegate string EncryptString(string p_str);
    public delegate string DecryptString(string p_str);

    public static class StringExtensions
    {
        public static EncryptString[] EncryptionMethods = new EncryptString[]
        {
            (str) => { return new string(str.Reverse().ToArray()); },
            (str) => { return str.EncryptLetters(3,5); }
        };

        public static DecryptString[] DecryptionMethods = new DecryptString[]
        {
            (str) => { return str.DecryptLetters(3,5); },
            (str) => { return new string(str.Reverse().ToArray()); }            
        };

        public static string EncryptLetters(this string p_str, params int[] p_Indexes)
        {
            StringBuilder strBuilder = new StringBuilder();

            for (int i = 0; i < p_str.Length; i++)
            {
                bool IsDivided = false;
                p_Indexes.ToList().ForEach(index => IsDivided = (IsDivided ||
                i % index == 0));

                if (IsDivided)
                    strBuilder.Append(Convert.ToChar(Convert.ToInt32(p_str[i]) + 1));
                else
                    strBuilder.Append(p_str[i]);
            }

            return strBuilder.ToString();
        }

        public static string DecryptLetters(this string p_str, params int[] p_Indexes)
        {
            StringBuilder strBuilder = new StringBuilder();

            for (int i = 0; i < p_str.Length; i++)
            {
                bool IsDivided = false;
                p_Indexes.ToList().ForEach(index => IsDivided = (IsDivided ||
                i % index == 0));

                if (IsDivided)
                    strBuilder.Append(Convert.ToChar(Convert.ToInt32(p_str[i]) - 1));
                else
                    strBuilder.Append(p_str[i]);
            }

            return strBuilder.ToString();
        }

        public static string Encrypt(this string p_str)
        {
            var result = p_str;

            foreach (var mEncryptionMethod in EncryptionMethods)
            {
                result = mEncryptionMethod(result);
            }

            return result;
        }

        public static string Decrypt(this string p_str)
        {
            var result = p_str;

            foreach (var mDecryptionMethod in DecryptionMethods)
            {
                result = mDecryptionMethod(result);
            }

            return result;
        }


    }
}
