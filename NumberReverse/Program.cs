using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] charArray = input.ToCharArray();

            StringBuilder newString = new StringBuilder();
            for (int i = charArray.Length - 1; i >= 0; i--)
                newString.Append(charArray[i]);

            Console.WriteLine(newString);
            Console.ReadLine();
        }
    }
}
