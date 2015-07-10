using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Class_Constraint
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            C c = new C();

            Test<A> t1 = new Test<A>(a);
            t1.SayHello();

            Test<B> t2 = new Test<B>(b);
            t2.SayHello();


        }
    }
}
