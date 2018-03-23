namespace GenericInterface
{


    interface IPrimitiveComparable
    {
        int CompareTo(object obj);
    }

    interface IGenericComparable<T>
    {
        int CompareTo(T obj);
    }

}
