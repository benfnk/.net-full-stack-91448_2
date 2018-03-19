using System;
using System.Collections.Generic;

namespace GenericContravarience
{

    class Program
    {
        static void Main()
        {
            Action<Button> one = (Button c) => { Console.WriteLine(c.Name); };
            Action<Control> two = (Control c) => { Console.WriteLine(c.Body); };


            List<Action<Button>> lst = new List<Action<Button>>();
            lst.Add(one);
            lst.Add(two);

            foreach (var item in lst)
            {
                item(new Button()
                {
                    Body = "Two",
                    Name = "One",
                });
            }
            
            Test();
        }

        /// <summary>
        /// Contravarience 
        /// </summary>

        // Contravariant interface.
        interface IContravariant<in A> { }

        // Extending contravariant interface.
        interface IExtContravariant<in A> : IContravariant<A> { }

        // Implementing contravariant interface.
        class Sample<A> : IContravariant<A> { }


        static void Test()
        {
            IContravariant<Object> iobj = new Sample<Object>();
            IContravariant<String> istr = new Sample<String>();

            // You can assign iobj to istr because
            // the IContravariant interface is contravariant.
            istr = iobj;
        }

        // Contravariant delegate.
        public delegate void DContravariant<in A>(A argument);

        // Methods that match the delegate signature.
        public static void SampleControl(Control control)
        { }
        public static void SampleButton(Button button)
        {
            Console.WriteLine(button.Name);
        }

        public void TestDelegate()
        {

            // Instantiating the delegates with the methods.
            DContravariant<Control> dControl = SampleControl;
            DContravariant<Button> dButton = SampleButton;

            // You can assign dControl to dButton
            // because the DContravariant delegate is contravariant.
            dButton = dControl;

            // Invoke the delegate.
            dButton(new Button());
        }        
    }

    internal class Control
    {
        public string Body { get; set; }
    }

    internal class Button : Control
    {
        public string Name { get; set; }
    }
}
