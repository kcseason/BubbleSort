using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APlusB
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ss = Console.ReadLine().Split();
            Console.WriteLine(long.Parse(ss[0]) + long.Parse(ss[1]));
            Console.ReadLine();
        }
    }
}
