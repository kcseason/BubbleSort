using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberExchange
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            a = a ^ b;
            b = a ^ b;
            a = a ^ b;

            Console.WriteLine(a + " " + b);
            Console.ReadKey();
        }
    }
}
