using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_B_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test(5, 4));
            Console.WriteLine(test(4, 3));
            Console.WriteLine(test(1, 4));
            Console.ReadLine();
        }
        public static bool test(int a, int b)
        {
            return a == 5 || b == 5 || a + b == 5 || Math.Abs(a - b) == 5;
        }
    }
}
