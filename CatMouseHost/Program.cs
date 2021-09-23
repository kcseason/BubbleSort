using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatMouseHost
{
    public class Cat
    {

        public delegate void ScreamHandler();
        public event ScreamHandler ScreamEvent;

        public void Scream()
        {
            Console.WriteLine("猫叫了");
            if (ScreamEvent != null)
            {
                ScreamEvent();
            }
        }
    }

    public class Rat
    {
        public void RunAway()
        {
            Console.WriteLine("快跑");
        }
    }

    public class Host
    {
        public void WakeUp()
        {
            Console.WriteLine("醒了");
        }
    }

    class program
    {
        static void Main()
        {
            Cat cat = new Cat();
            Rat rat = new Rat();
            Host host = new Host();

            cat.ScreamEvent += rat.RunAway;
            cat.ScreamEvent += host.WakeUp;

            cat.Scream();
            Console.ReadLine();

        }
    }
}
