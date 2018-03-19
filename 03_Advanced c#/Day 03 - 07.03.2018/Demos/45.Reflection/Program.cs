using System;
using System.Reflection;
using System.Runtime.Remoting;

namespace _45.Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            TypeInformation();
            MemberInformation();
            CreateInstance1();
            CreateInstance2();
        }

        static void TypeInformation()
        {
            Type t = typeof(Person);
            Console.WriteLine(t.Name);
            Console.WriteLine(t.FullName);
            Console.WriteLine(t.IsAbstract);
            Console.WriteLine(t.IsArray);
            Console.WriteLine(t.IsClass);
            Console.WriteLine(t.IsValueType);
            Console.WriteLine(t.IsAssignableFrom(typeof(object)));
            Console.WriteLine(t.IsSubclassOf(typeof(object)));
        }

        static void MemberInformation()
        {
            Type t = typeof(Person);
            MethodInfo[] methods = t.GetMethods();
            foreach (var item in methods)
                Console.WriteLine(item);

            PropertyInfo[] props = t.GetProperties();
            foreach (var item in props)
                Console.WriteLine(item);
        }

        static void CreateInstance1()
        {
            ObjectHandle handle = Activator.CreateInstance("Reflection Example", "Reflection_Example.Person");
            object p = handle.Unwrap();
            Type personType = p.GetType();
            PropertyInfo pFirstName = personType.GetProperty("FirstName");
            PropertyInfo pLastName = personType.GetProperty("LastName");
            pFirstName.SetValue(p, "Moishe");
            pLastName.SetValue(p, "Ufnik");
            MethodInfo mPrint = personType.GetMethod("Print", BindingFlags.Instance | BindingFlags.Public | BindingFlags.FlattenHierarchy);
            mPrint.Invoke(p, null);
            personType.InvokeMember("print", BindingFlags.Public | BindingFlags.Instance |
                BindingFlags.InvokeMethod | BindingFlags.IgnoreCase, null, p, null);
        }
        static void CreateInstance2()
        {
            Assembly asm = Assembly.LoadFile(@"C\...\Reflection Example.exe");
            // or: 
            //Assembly asm = Assembly.GetExecutingAssembly();
            Type personType = asm.GetType("Reflection_Example.Person");
            object p = Activator.CreateInstance(personType, new object[] { "Kipi", "Ben-Kipod" });
            MethodInfo mPrint = personType.GetMethod("Print", BindingFlags.Instance | BindingFlags.Public | BindingFlags.FlattenHierarchy);
            mPrint.Invoke(p, null);
            personType.InvokeMember("print", BindingFlags.Public | BindingFlags.Instance |
                BindingFlags.InvokeMethod | BindingFlags.IgnoreCase, null, p, null);
        }
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person() { }

        public Person(string fName, string lName)
        {
            FirstName = fName;
            LastName = lName;
        }

        public void Print()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(FirstName + " " + LastName);
            Console.ResetColor();
        }
    }
}
