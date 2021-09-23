using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThread2
{
    public class 同步调用
    {
        static void Main()
        {
            Console.WriteLine("===== 同步调用 SyncInvokeTest =====");
            AddHandler handler = new AddHandler(加法类.Add);
            int result = handler.Invoke(1, 2);
            Console.WriteLine("继续做别的事情。。。");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }

    //public class 异步调用
    //{
    //    static void Main()
    //    {
    //        Console.WriteLine("===== 异步调用 AsyncInvokeTest =====");
    //        AddHandler handler = new AddHandler(加法类.Add);
    //        //IAsyncResult: 异步操作接口(interface)
    //        //BeginInvoke: 委托(delegate)的一个异步方法的开始
    //        IAsyncResult result = handler.BeginInvoke(1, 2, null, null);
    //        Console.WriteLine("继续做别的事情。。。");
    //        //异步操作返回
    //        Console.WriteLine(handler.EndInvoke(result));
    //        Console.ReadKey();
    //    }
    //}

    //public class 异步回调
    //{
    //    static void Main()
    //    {
    //        Console.WriteLine("===== 异步回调 AsyncInvokeTest =====");
    //        AddHandler handler = new AddHandler(加法类.Add);
    //        //异步操作接口(注意BeginInvoke方法的不同！)
    //        IAsyncResult result = handler.BeginInvoke(1, 2, new AsyncCallback(回调函数), "AsycState:OK");
    //        Console.WriteLine("继续做别的事情。。。");
    //        Console.ReadKey();
    //    }

    //    static void 回调函数(IAsyncResult result)
    //    {
    //        //result 是“加法类.Add()方法”的返回值
    //        //AsyncResult 是IAsyncResult接口的一个实现类，空间：System.Runtime.Remoting.Messaging
    //        //AsyncDelegate 属性可以强制转换为用户定义的委托的实际类。
    //        AddHandler handler = (AddHandler)((AsyncResult)result).AsyncDelegate;
    //        Console.WriteLine(handler.EndInvoke(result));
    //        Console.WriteLine(result.AsyncState);
    //    }
    //}


    public delegate int AddHandler(int a, int b);
    public class 加法类
    {
        public static int Add(int a, int b)
        {
            Console.WriteLine("开始计算：" + a + "+" + b);
            Thread.Sleep(3000); //模拟该方法运行三秒
            Console.WriteLine("计算完成！");
            return a + b;
        }
    }
}
