using System;
using System.Collections.Generic;

namespace _14.GenericCovariance
{

    // Covariant interface.
    interface ICovariant<out R> { }

    // Extending covariant interface.
    interface IExtCovariant<out R> : ICovariant<R> { }

    // Implementing covariant interface.
    class Sample<R> : ICovariant<R> { }

    class Program
    {
        static void Main(string[] args)
        {
            List<Func<Button, Control>> lstFuncs = new List<Func<Button, Control>>();

            lstFuncs.Add((Button c) => { return new Control();});
            lstFuncs.Add((Button c) => { return new Button(); });
            lstFuncs.Add(new Func<Control, Control>((Control c) => { return new Button(); }));
            // Will Not Compile
            //lstFuncs.Add(new Func<Control, Base>((Control c) => { return new Base(); }));

        }
        static void Test()
        {
            ICovariant<Object> iobj = new Sample<Object>();
            ICovariant<String> istr = new Sample<String>();

            // You can assign istr to iobj because
            // the ICovariant interface is covariant.
            iobj = istr;
        }

        // Covariant delegate.
        public delegate R DCovariant<out R>();

        // Methods that match the delegate signature.
        public static Control SampleControl()
        { return new Control(); }

        public static Button SampleButton()
        { return new Button(); }

        public void Test2()
        {
            // Instantiate the delegates with the methods.
            DCovariant<Control> dControl = SampleControl;
            DCovariant<Button> dButton = SampleButton;

            // You can assign dButton to dControl
            // because the DCovariant delegate is covariant.
            dControl = dButton;

            // Invoke the delegate.
            dControl();
        }
    }

    internal class Button : Control
    {
        public Button()
        {
        }
    }

    internal class Control : Base
    {
        public Control()
        {
        }
    }

    internal class Base
    {
        public Base()
        {
        }
    }

}
