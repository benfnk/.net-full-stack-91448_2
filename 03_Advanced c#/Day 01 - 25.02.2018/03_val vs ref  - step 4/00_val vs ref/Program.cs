using System;

namespace _00_val_vs_ref
{
    class Pizza
    {
        public bool IsVeg { get; set; }
    }

    struct Salad
    {
        public bool IsVeg { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {


            //class has a pointer in the stack
            //that refers the value in the heap
            Pizza pizza = new Pizza { IsVeg = false };

            //struct is in the stack
            Salad salad = new Salad { IsVeg = false };


            Pizza pizzaCopy = pizza;
            Salad saladCopy = salad;

            Console.WriteLine($"1) pizza.IsVeg: {pizza.IsVeg}");
            Console.WriteLine($"1) pizzaCopy.IsVeg: {pizzaCopy.IsVeg}");
            pizzaCopy.IsVeg = !pizzaCopy.IsVeg;
            Console.WriteLine($"2) pizza.IsVeg: {pizza.IsVeg}");
            Console.WriteLine($"2) pizzaCopy.IsVeg: {pizzaCopy.IsVeg}");

            Console.WriteLine($"3) salad.IsVeg: {salad.IsVeg}");
            Console.WriteLine($"3) saladCopy.IsVeg: {saladCopy.IsVeg}");
            saladCopy.IsVeg = !saladCopy.IsVeg;
            Console.WriteLine($"4) salad.IsVeg: {salad.IsVeg}");
            Console.WriteLine($"4) saladCopy.IsVeg: {saladCopy.IsVeg}");

            Pizza pizzaDeepCopy = new Pizza {IsVeg = pizza.IsVeg};
            Salad saladDeepCopy = new Salad { IsVeg = salad.IsVeg };

            Console.WriteLine($"5) pizza.IsVeg: {pizza.IsVeg}");
            Console.WriteLine($"5) pizzaDeepCopy.IsVeg: {pizzaDeepCopy.IsVeg}");
            pizzaDeepCopy.IsVeg = !pizzaDeepCopy.IsVeg;
            Console.WriteLine($"6) pizza.IsVeg: {pizza.IsVeg}");
            Console.WriteLine($"6) pizzaDeepCopy.IsVeg: {pizzaDeepCopy.IsVeg}");


            Console.WriteLine($"7) salad.IsVeg: {salad.IsVeg}");
            Console.WriteLine($"7) saladDeepCopy.IsVeg: {saladDeepCopy.IsVeg}");
            saladDeepCopy.IsVeg = !saladDeepCopy.IsVeg;
            Console.WriteLine($"8) salad.IsVeg: {salad.IsVeg}");
            Console.WriteLine($"8) saladDeepCopy.IsVeg: {saladDeepCopy.IsVeg}");


        }


    }


}



/*
 * output:
 * 
1) pizza.IsVeg: False
1) pizzaCopy.IsVeg: False
2) pizza.IsVeg: True
2) pizzaCopy.IsVeg: True
3) salad.IsVeg: False
3) saladCopy.IsVeg: False
4) salad.IsVeg: False
4) saladCopy.IsVeg: True
5) pizza.IsVeg: True
5) pizzaDeepCopy.IsVeg: True
6) pizza.IsVeg: True
6) pizzaDeepCopy.IsVeg: False
7) salad.IsVeg: False
7) saladDeepCopy.IsVeg: False
8) salad.IsVeg: False
8) saladDeepCopy.IsVeg: True
 */
