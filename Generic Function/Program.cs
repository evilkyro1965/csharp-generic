using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3 };
            int[] nums2 = new int[4];

            ArrayUtils.CopyInsert(99, 2, nums, nums2);

            Console.WriteLine("Contents of nums2: ");
            foreach (int x in nums2)
                Console.Write(x + " ");
            Console.WriteLine();
        }
    }
}
