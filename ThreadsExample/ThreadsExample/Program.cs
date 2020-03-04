using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadsExample
{
    class Program
    {
        static int count = 0;

        static void Main(string[] args)
        {
            ThreadStart threadStart = Method;
            Thread t1 = new Thread(new ThreadStart(Method));
            Thread t2 = new Thread(new ThreadStart(Method));
            Thread t3 = new Thread(new ThreadStart(Method));

            t1.Start();
            t2.Start();
            t3.Start();

            t1.Join();
            t2.Join();
            t3.Join();

            Console.WriteLine(count);
            //for (int i = 0; i < 100; i++)
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine($"{i} Hello from main!");
            //}



        }
        static readonly object _lock = new object();

        static void Method()
        {
            for (int i = 0; i < 100000; i++)
            {
                lock (_lock)
                {
                   count++;
                }
            }
        }
    }
}
