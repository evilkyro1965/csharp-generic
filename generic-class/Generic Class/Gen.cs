using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Class
{
    using System;

    class Gen<T>
    {
        T ob;

        public Gen(T o)
        {
            ob = o;
        }

        public T GetOb()
        {
            return ob;
        }

        public void Showtype()
        {
            Console.WriteLine("Type of T is " + typeof(T));
        }

    }
}
