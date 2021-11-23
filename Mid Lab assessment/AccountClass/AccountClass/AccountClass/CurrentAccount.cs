using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountClass
{
    internal class CurrentAccount : Account
    {
        private double cgpa;

        internal double Cgpa
        {
            get { return this.cgpa; }
            set { this.cgpa = value; }
        }

        /*
        internal override void Transfer(string sender, string receiver, double amount)
        {
            if (this.Balance > amount)
            {
                if (amount <= 2000)
                {
                    base.Withdraw(amount);
                }
                else
                {
                    Console.WriteLine("You cannot withdraw more than 2000 at once!!!");
                }
            }
            else
            {
                Console.WriteLine("Not Sufficient Balance in your Account!!!");
            }
        }

        internal override void Withdraw(double amount)
        {
            if (this.Balance > amount)
            {
                if (amount <= 5000)
                {
                    base.Withdraw(amount);
                }
                else
                {
                    Console.WriteLine("You cannot withdraw more than 2000 at once!!!");
                }
            }
            else
            {
                Console.WriteLine("Not Sufficient Balance in your Account!!!");
            }
        }
        */
        internal override string Id
        {
            set { base.Id = value + "-C"; }
        }

        internal CurrentAccount(string name, MyDate dateOfBirth, OurAddress address, double balance, double cgpa) : base(name, dateOfBirth, address, balance)
        {
            this.Cgpa = cgpa;
        }

        internal override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Cgpa {0}", Cgpa);
        }
        /* internal SavingsClass():this("xyz")
         {
             Console.WriteLine("SavingClass");
         }
         internal SavingsClass(int q):this()
         {
             Console.WriteLine("SavingClass "+q);
         }
         internal SavingsClass(string q) : base(32)
         {
             Console.WriteLine("SavingClass " + q);
         }
         internal override void M1()
         {
             Console.WriteLine("SavingClass m1");
         }*/
    }
}
