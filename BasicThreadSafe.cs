using System;
using System.Collections.Generic;
using System.Threading;

namespace Threading
{

    /*
     *  Basic program to show
     *  -  how program can be made thread safe using locks
     *  - REMEMBER that locks are lightweight for in thread exclusive lock
     *  MUTEX are similar concept for spans across Apps/Processes and are expensive
     *  and mostly require hardware support
     *  Semaphores allow non-exclusive locks
     */
    class BasicThreadSafeShare
    {
        public static bool done;
        public static readonly object locker = new object();

        public static void Go()
        {
            lock (locker)
            {
                if (!done)
                {
                    Console.WriteLine("Printing"); // prints twice
                    done = true; // not thread safe
                }
            }
        }

        public static void Main()
        {
            Thread t = new Thread(Go);
            t.Start();
            Thread.Sleep(5000);
            Go();
        }
    }
}
