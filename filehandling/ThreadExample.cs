using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threadfile
    {
        internal class ThreadExample
        {
            public static void display()
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("Process " + i);
                    Thread.Sleep(1000); // Correct usage of Thread.Sleep
                }
            }

            public static void Main(string[] args)
            {
                ThreadStart obj = new ThreadStart(display); // Delegate to the display method
                System.Threading.Thread t = new System.Threading.Thread(obj); // Fully qualified name
                t.Start();
            t.Join();
            System.Threading.Thread t1 = new System.Threading.Thread(obj); // Fully qualified name
            t1.Start();

        }
        }
    }



    

