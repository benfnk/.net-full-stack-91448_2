using System;

namespace GenericInterface
{
    class Person : IPrimitiveComparable, IGenericComparable<Person>
    {
        public string Name { get; set; }

        public int CompareTo(object obj)
        {
            if(obj is Person)
            {
                if ((obj as Person).Name.Length > this.Name.Length)
                    return -1;
                else if ((obj as Person).Name.Length > this.Name.Length)
                    return 0;                
                else
                    return 1;
            }

            throw new Exception();
        }

        public int CompareTo(Person obj)
        {
            if ((obj as Person).Name.Length > this.Name.Length)
                return -1;
            else if ((obj as Person).Name.Length > this.Name.Length)
                return 0;
            else
                return 1;
        }     
    }
}
