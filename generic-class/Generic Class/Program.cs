using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Gen<int> iOb;

            iOb = new Gen<int>(102);

            iOb.Showtype();

            int v = iOb.GetOb();

            Console.WriteLine("Value : " + v);
            Console.WriteLine();

            Gen<string> strOb = new Gen<string>("Generics add power.");

            strOb.Showtype();

            string str = strOb.GetOb();
            Console.WriteLine("Value : " + str);

        }
    }
}
