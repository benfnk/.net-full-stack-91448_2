using System;

namespace OperatorOverloading
{
    public struct Complex
    {
        public int real { get; set; }
        public int imaginary { get; set; }

    public Complex(int real, int imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        // Declare which operator to overload (+), the types 
        // that can be added (two Complex objects), and the 
        // return type (Complex):
        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.real + c2.real, c1.imaginary + c2.imaginary);
        }

        // Unary Operator
        public static Complex operator ++(Complex c1)
        {
            return new Complex(c1.real +1, c1.imaginary);
        }

        // Equal
        public static bool operator ==(Complex c1, Complex c2)
        {
            return c1.real == c2.real && c1.imaginary == c2.imaginary;
        }

        public static bool operator !=(Complex c1, Complex c2)
        {
            return c1.real != c2.real && c1.imaginary != c2.imaginary;
        }

        public int this [int index]
        {
            get
            {
                if (index == 0)
                    return real;
                else
                    return imaginary;
            }

            set
            {
                if (index == 0)
                    real = value;
                else
                    imaginary = value;
            }
        }

        // Change Complex to String
        public static implicit operator string(Complex c1)
        {
            return c1.ToString();
        }

        // Change Complex to String
        public static implicit operator Complex(string c1)
        {
            return new Complex(int.Parse(c1.Split(new char[] { ' ', '+' }, StringSplitOptions.RemoveEmptyEntries)[0]),
                int.Parse(c1.Split(new char[] { ' ', '+', 'i' }, StringSplitOptions.RemoveEmptyEntries)[1]));
        }


        // Override the ToString method to display an complex number in the suitable format:
        public override string ToString()
        {
            return (String.Format("{0} + {1}i", real, imaginary));
        }
    }
}
