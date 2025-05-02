using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_practice
{
    internal class Eventexample
    {
        public delegate String DemoDelegate(string str1, string str2);
        event DemoDelegate myEvent;
        Eventexample() 
        {
            this.myEvent += Event_myEvent;
        }

        private string Event_myEvent(string str1, string str2)
        {
       return "hello " + str1 + str2;
        }
        public static void Main(string[] args)
        {
            Eventexample e = new Eventexample();
            Console.WriteLine(e.myEvent("hello 1 ", "hello 2"));
        }
      

    }
}
