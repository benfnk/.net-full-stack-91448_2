namespace GenericInterface
{
    interface IMonth<T> { }

    interface IJanuary : IMonth<int> { }  //No error
    interface IFebruary<T> : IMonth<int> { }  //No error
    interface IMarch<T> : IMonth<T> { }    //No error
  //interface IApril<T>  : IMonth<T, U> {}  //Error

    interface IBaseInterface1<T> { }
    interface IBaseInterface2<T, U> { }

    class SampleClass1<T> : IBaseInterface1<T> { }          //No error
    class SampleClass2<T> : IBaseInterface2<T, string> { }  //No error

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
