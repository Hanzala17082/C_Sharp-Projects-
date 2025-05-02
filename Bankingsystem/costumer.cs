using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankingsystem
{
    internal class Costumer
    {
        public static void Main(string[] args)
        {
            Bank obj = new Bankimplementation();
            obj.Credit(120);
            obj.Checkbalance();

            Promotion obj1= new Bankimplementation();
            obj1.branding();
        }
    }
}
