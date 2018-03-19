namespace GenericInheritance
{
    class A<T>
    {
        public T Value;
    }

    class B : A<int>
    {
    }

    class C<G> : A<G>
    {
    }

    class D<G> : A<string>
    {
    }

    class Alien
    {
    }

    class E<T> : Alien
    {
    }
    /// <summary>
    /// /////////////////////////////////////////////////////////
    /// </summary>
    

    class BaseNode { }
    class BaseNodeGeneric<T> { }

    // concrete type
    class NodeConcrete<T> : BaseNode { }

    //closed constructed type
    class NodeClosed<T> : BaseNodeGeneric<int> { }

    //open constructed type 
    class NodeOpen<T> : BaseNodeGeneric<T> { }

    //No error
    class Node1 : BaseNodeGeneric<int> { }

    //Generates an error
    //class Node2 : BaseNodeGeneric<T> {}

    //Generates an error
    //class Node3 : T {}

    class BaseNodeMultiple<T, U> { }

    //No error
    class Node4<T> : BaseNodeMultiple<T, int> { }

    //No error
    class Node5<T, U> : BaseNodeMultiple<T, U> { }

    //Generates an error
    //class Node6<T> : BaseNodeMultiple<T, U> {} 

    class NodeItem<T> where T : System.IComparable<T>, new() { }
    class SpecialNodeItem<T> : NodeItem<T> where T : System.IComparable<T>, new() { }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
