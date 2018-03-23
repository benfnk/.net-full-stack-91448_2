using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsClassMethod
{ 
    public class SMS<TSubject, TMessage> where TSubject:struct, IReadable 
                                         where TMessage : class
    {
        
    }
}
