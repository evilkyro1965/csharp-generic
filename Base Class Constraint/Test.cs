using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Class_Constraint
{
    class Test<T> where T : A 
    {
        T obj;

        public Test(T o)
        {
            obj = o;
        }

        public void SayHello()
        {
            obj.Hello();
        }
    }
}
