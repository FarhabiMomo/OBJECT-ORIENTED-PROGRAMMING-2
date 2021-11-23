using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountClass
{
    internal class Loan:Account
    {
        private double salary;

        internal double Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }

        internal override string Id
        {
            set { base.Id = value + "-l"; }
        }

        internal Loan( string name, MyDate dateOfBirth, OurAddress address, double balance, double salary) : base( name, dateOfBirth, address, balance)
        {
            this.Salary = salary;
        }
        internal override void Withdraw(double amount)
        {
            if(this.Balance > (amount+50))
            {
                amount += 50;
                base.Withdraw(amount);
            }
            else
            {
                Console.WriteLine("You cannot Withdraw not sufficient Balance!!!");
            }
        }

        internal override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Salary: {0}\n", this.Salary);
        }
    }
}

