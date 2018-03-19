using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covariance
{
    public class Human

    {
        public string ControlName { get; set; }
    }

    public class Woman : Human
    {
        public string ButtonName { get; set; }
    }

    public class FrenchWoman : Woman
    {
        public string Color { get; set; }
    }

    public delegate void MyAction<in T>(T param);

    public delegate T MyFunc<T>();

    class Program
    {
        static void Main(string[] args)
        {
            MyAction<Human> action = (Human c) => Console.WriteLine(c.ControlName);
            MyAction<Woman> action2 = (Woman b) => Console.WriteLine(b.ButtonName);
            MyAction<FrenchWoman> action3 = (FrenchWoman rb) => Console.WriteLine(rb.Color);

            List<MyAction<Woman>> arract = new List<MyAction<Woman>>();
            arract.Add(action);
            arract.Add(action2);

            foreach (var aAction in arract)
            {
                aAction(new Woman()
                {
                    ButtonName = "Button",
                    ControlName = "Control"
                });
            }

            List<MyFunc<Woman>> arrfuncs = new List<MyFunc<Woman>>();
            arrfuncs.Add(ReturnFrench);

            //arract.Add(action3);

            //action2 += PrintControl;
            //action2(new Button());



        }

        public static void PrintControl(Human c)
        {
            Console.WriteLine(c);
        }

        public static FrenchWoman ReturnFrench()
        {
            return new FrenchWoman();
        }

        public static void PrintButton(Woman b)
        {
            Console.WriteLine(b);
        }
    }
}
