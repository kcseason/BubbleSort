using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkList<string> test = new LinkList<string>();
            test.Append("1");
            test.Append("2");
            test.Append("3");
            test.Append("4");
            test.Reverse();

            for (int i = 1; i <= test.GetLength(); i++)
                Console.Write(test.GetElem(i) + " ");

            Console.ReadKey();
        }
    }
}
