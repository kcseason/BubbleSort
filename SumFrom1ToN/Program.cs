using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumFrom1ToN
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());

            Console.WriteLine(Sum(n));
            Console.ReadLine();
        }

        static long Sum(long n)
        {
            if (n <= 0)
                return 0;

            return n * (n + 1) / 2;
        }
    }
}
