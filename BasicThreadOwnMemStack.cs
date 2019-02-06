using System;
using System.Collections.Generic;
using System.Threading;

namespace Threading
{
    /*
     * Simple program to show
     *   that threads use their own mem stack
     * 
     * 
     * 
     */
    class BasicThreadOwnMemStack
    {
        public static void Go()
        {
            int count = 0;
            while (count <= 10)
            {
                Console.WriteLine(count++);
                Thread.Sleep(300);
            }
        }

        //public static void Main()
        //{
        //    Thread t = new Thread(Go);
        //    t.Start();
        //    Go();
        //}
    }
}
