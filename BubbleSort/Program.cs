using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] SortArray = new int[] { 34, 11, 22, 55, 778, 99, 7, 52, 88, 101 };
            Console.WriteLine("排列前序列：");
            for (int i = 0; i < SortArray.Length; i++)
                Console.Write(SortArray[i] + " ");

            for (int i = SortArray.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (SortArray[j] > SortArray[j + 1])
                    {
                        int temp = SortArray[j];
                        SortArray[j] = SortArray[j + 1];
                        SortArray[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("排列后序列");
            for (int i = 0; i < SortArray.Length; i++)
                Console.Write(SortArray[i] + " ");

            Console.ReadLine();
        }
    }
}
