using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsClassMethod
{
    public class Example : Point, IReadable, IWriteable
    {
        public Example()
        {

        }

        public Example(int a)
        {

        }

        bool IReadable.WriteToFile()
        {
            throw new NotImplementedException();
        }

        bool IWriteable.WriteToFile()
        {
            throw new NotImplementedException();
        }
    }
}
