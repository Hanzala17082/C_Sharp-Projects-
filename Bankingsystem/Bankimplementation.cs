using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankingsystem
{
    internal class Bankimplementation : Bank, Promotion
    {
        int balance = 5000;

        public void branding()
        {
            Console.WriteLine("Branding");
        }

        public  void Checkbalance()
        {
            if (this.Login(17082))
            {
                Console.WriteLine("Balance is  {0}", balance);
            }
            else
            {
                Console.WriteLine("Invalid code");
            }
           

        }

        public void Credit(int amount)
        {
            if (this.Login(17082))
            {
                balance += amount;
            }
            else
            {
                Console.WriteLine("Invalid code");
            }

           
        }

        public void Debit(int amount)
        {
            if (this.Login(17082))
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Invalid code");
            }
        }

        public bool Login(int pincode)
        {
            if (pincode == 17082)
            {
             return true;
            }
            else
            {
           ;
                return false;
            }
        }

        public void marketing()
        {
          Console.WriteLine("Marketing ");
        }
    }
}
