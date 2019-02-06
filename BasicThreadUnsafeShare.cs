using System;
using System.Collections.Generic;
using System.Threading;

namespace Threading
{

    /*
     *  Basic program to show
     *  -  how thread can share data either using static field 
     *  - or same reference
     *  - Also show the issues with sharing data if not used synchronization primitives
     * 
     */
    class BasicThreadUnsafeShare
    {
        public static bool done;

        public static void Go()
        {
            if(!done) 
            {
                Console.WriteLine("Printing"); // prints twice
                done = true; // not thread safe
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
