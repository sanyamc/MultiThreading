using System;
using System.Threading;

namespace Threading
{

    class Counter
    {
        public void Count()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("i is: " + i);
                Thread.Sleep(500);
            }
        }
    }
    class Driver
    {
        //static void Main(string[] args)
        //{
        //        var c = new Counter();

        //        //var job = new ThreadStart(c.Count);
        //        Thread th = new Thread(c.Count);
        //        th.Start();
            
        //        for(int j=0;j<10;j++)
        //        {
        //            Console.WriteLine("j is " + j);
        //            Thread.Sleep(700);
        //        }
        //    //Console.WriteLine("Hello World!");

            
       // }
    }
}
