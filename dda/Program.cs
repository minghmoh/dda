using System;
using System.Threading;
namespace dda
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Thread t = new Thread(() => { Thread.Sleep(3333); Console.WriteLine(23423); });
            t.Start();

            Thread t2 = new Thread(() => { Thread.Sleep(1000); Console.WriteLine(23423); });
            t2.Start();
            t2.Join();
            Thread t3 = new Thread(() => { Console.WriteLine("im the best"); });
            t3.Start();

        }
    }
}
