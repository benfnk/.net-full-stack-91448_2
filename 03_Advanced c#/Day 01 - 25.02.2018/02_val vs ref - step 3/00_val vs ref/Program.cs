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


            Console.WriteLine($"var0.IsEatable {var0.IsEatable} before function");
            Console.WriteLine($"var1.IsEatable {var1.IsEatable} before function");

            functionChangeIEatable(var0);
            functionChangeIEatable(var1);

            Console.WriteLine($"var0.IsEatable {var0.IsEatable} after function");
            Console.WriteLine($"var1.IsEatable {var1.IsEatable} after function");
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"functionChangePizza {var4.IsEatable} before function");
            functionChangePizza(var4);
            Console.WriteLine($"functionChangePizza {var4.IsEatable} after function");
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"functionChangeSalad {var5.IsEatable} before function");
            functionChangeSalad(var5);
            Console.WriteLine($"functionChangeSalad {var5.IsEatable} after function");
            
        }


        //IEatable - can be or Salad (struct) or Pizza (class)
        //Because interface is allways a pointer
        //the changes will be also after the function is done 
        static void functionChangeIEatable(IEatable i)
        {
            i.IsEatable = !i.IsEatable;
        }


        //Salad is a struct - so the changes will only be in the function
        static void functionChangeSalad(Salad i)
        {
            i.IsEatable = !i.IsEatable;
        }

        //Pizza is a class - so the changes will be also after the function is done
        static void functionChangePizza(Pizza i)
        {
            i.IsEatable = !i.IsEatable;
        }
    }


}



/*
 * output:
 * 
var0.IsEatable True before function
var1.IsEatable True before function
var0.IsEatable False after function
var1.IsEatable False after function
-----------------------------
functionChangePizza False before function
functionChangePizza True after function
-----------------------------
functionChangeSalad True before function
functionChangeSalad True after function
 */
