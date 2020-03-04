using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadsExample_Paramaeters
{
    class Program
    {
        static void Main(string[] args)
        {
            ParameterizedThreadStart threadStart = new ParameterizedThreadStart(ThreadFunk);

            Thread thread = new Thread(threadStart);
            thread.IsBackground = false;
            thread.Start((object)"1");

            Thread thread1 = new Thread(threadStart);
            thread.IsBackground = false;
            thread1.Start((object)"2");
        }

        static void ThreadFunk(object a)
        {
            string id = (string)a;
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i + " " + id);
            }
        }
    }
}
