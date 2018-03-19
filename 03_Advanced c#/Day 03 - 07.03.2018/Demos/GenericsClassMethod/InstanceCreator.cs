using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsClassMethod
{
    public class InstanceCreator<T> where T : Point,IReadable, IWriteable, new()
    {
        public T CreateInstance()
        {
            T obj = new T();
            ((IReadable)obj).WriteToFile();
            return obj;
        }

    }
}
