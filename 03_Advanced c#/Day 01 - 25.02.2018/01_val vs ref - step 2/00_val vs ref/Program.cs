using System;

namespace _00_val_vs_ref
{
    interface IEatable
    {
        bool IsEatable { get; set; }
    }

    delegate void delg();

    enum Color
    {
        magenta=2
    }

    class Pizza: IEatable
    {
        public bool IsEatable { get; set; }
        public bool IsVeg { get; set; }
    }

    struct Salad: IEatable
    {
        public bool IsEatable { get; set;}
        public bool IsVeg { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            //delegate has a pointer in the stack
            //that refers the value in the heap
            delg var2 = () => Console.WriteLine("I am a delegate");

            //enum is in the stack 
            Color var3 =Color.magenta;

            //class has a pointer in the stack
            //that refers the value in the heap
            Pizza var4 =new Pizza { IsEatable = true, IsVeg = false };

            //struct is in the stack
            Salad var5 =new Salad {IsEatable=true, IsVeg=false };

            //interface can point to the stack or to the heap
            IEatable var0 =var4;  //interface points to class (heap)
            IEatable var1=var5;   //interface points to struct (stack)
        }
    }


}
