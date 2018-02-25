using System;

namespace _00_val_vs_ref
{
    class Pizza
    {
        public bool IsVeg;
    }

    struct Salad
    {
        public bool IsVeg;

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

            Pizza pizzaDeepCopy = new Pizza {IsVeg = pizza.IsVeg};
            Salad saladDeepCopy = new Salad { IsVeg = salad.IsVeg };



            //compares the refs and not the vals
            Console.WriteLine($"pizza==pizzaCopy: {pizza==pizzaCopy}");
            Console.WriteLine($"pizza == pizzaDeepCopy: {pizza == pizzaDeepCopy}");

            //compares the vals
            Console.WriteLine($"pizza.IsVeg==pizzaCopy.IsVeg: {pizza.IsVeg == pizzaCopy.IsVeg}");
            Console.WriteLine($"pizza.IsVeg == pizzaDeepCopy.IsVeg: {pizza.IsVeg == pizzaDeepCopy.IsVeg}");

            //Operator '==' cannot be applied to operands of type 'Salad' and 'Salad'
            //Console.WriteLine($"pizzaCopy==pizza: {saladCopy == salad}");  //-->compilation error

            //compares the vals
            Console.WriteLine($"salad.IsVeg==saladCopy.IsVeg: {salad.IsVeg == saladCopy.IsVeg}");
            Console.WriteLine($"salad.IsVeg == saladDeepCopy.IsVeg: {salad.IsVeg == saladDeepCopy.IsVeg}");



        }

    }

}



/*
 * output:
 * 
pizza==pizzaCopy: True
pizza == pizzaDeepCopy: False
pizza.IsVeg==pizzaCopy.IsVeg: True
pizza.IsVeg == pizzaDeepCopy.IsVeg: True
salad.IsVeg==saladCopy.IsVeg: True
salad.IsVeg == saladDeepCopy.IsVeg: True
 */
