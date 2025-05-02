using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankingsystem
{
    internal class billingnew : BILLING

    {
        public override float calcbill(int finalamount)
        {
            return finalamount + (finalamount * 0.18F);
        }

        public static void Main(string[] args)
        {
            BILLING obj = new billingnew();
            Console.WriteLine(obj.calcbill(100));
        }
    }
}
