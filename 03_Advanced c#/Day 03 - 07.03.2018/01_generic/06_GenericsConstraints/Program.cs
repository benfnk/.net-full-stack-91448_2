using System.Collections.Generic;

namespace GenericsConstraints
{
    public class SMS
    {
        public string Body { get; set; }
    }

    public class MMS : SMS
    {

    }

    public interface IDisplayable
    {
        void Display(string s);
    }

    public class SMSCollection<T> : List<T> where T: SMS, IDisplayable 
        //,IComparable<T>        
    {
        public void AddAndDisplay(T item)
        {
            this.Add(item);
            item.Display(item.Body);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GenericList<SMS> a = new GenericList<SMS>();
            a.AddHead(new MMS());

            GenericList<MMS> lst = new GenericList<MMS>();
            a.AddGenericList(lst);


        }
    }
}
