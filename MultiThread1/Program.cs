using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThread1
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            Thread td = new Thread(new ThreadStart(Test));
            td.IsBackground = true;
            td.Start();

            for (var i = 0; i < 100; i++)
            {
                Console.WriteLine("主线程计数" + i);
                //Thread.Sleep(100);
            }
            Console.WriteLine("主线程计数结束");

            Console.ReadKey();
        }

        private static void Test()
        {
            for (var i = 0; i < 200; i++)
            {
                Console.WriteLine("后台线程计数" + i);
                //Thread.Sleep(100);
            }
            Console.WriteLine("后台线程计数结束");
        }
    }
}
