//A stack is a restricted data structure, 
//because only a small number of operations are performed on it.
//The nature of the pop and push operations 
//also means that stack elements have a natural order. 
//Elements are removed from the stack in the reverse order 
//to the order of their addition: therefore, 
//the lower elements are those that have been on the stack the longest


using System;

namespace stack
{
    class stack
    {
        int k;
        int[] stack1;

        public stack(int n)
        {
            k = 0;
            stack1 = new int[n];
        }
        public void push(int ak)
        {

            stack1[k] = ak;
            k++;

        }
        public int pop()
        {
            return stack1[k--];
        }

        public void show()
        {

            for (int i = 0; i < k; i++)
            {

                Console.WriteLine("value pushed at stack ={0}", stack1[i]);

            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            stack a = new stack(10);
            a.push(4);
            a.push(3);
            a.push(7);
            a.push(145);
            a.push(105);
            a.push(104);
            a.pop();
            a.show();

        }
    }
}