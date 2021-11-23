using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyClass
{
    struct Date
    {
       private  int date;
        private string month;
        private int year;

        public Date(int date, string month, int year)
        {
            this.date = date;
            this.month = month;
            this.year = year;
        }
        public void ShowDate()
        {
            //Console.WriteLine("Date Info:");
            Console.WriteLine("Joining Date: {0}, {1} {2}", this.date, this.month, this.year);
        }
    }
    struct OurAddress
    {
        private int houseNo;
        private string streetName;
        private string upazilaName;

        public OurAddress(int houseNo, string streetName, string upazilaName)
        {
            this.houseNo = houseNo;
            this.streetName = streetName;
            this.upazilaName = upazilaName;

        }

        public void ShowAddress()
        {
            Console.WriteLine("Address Info");
            Console.WriteLine("House no: {0}", this.houseNo);
            Console.WriteLine("Street name: {0}", this.streetName);
            Console.WriteLine("Upazila name: {0}", this.upazilaName);
        }
    }
    class Employee
    {
        private ushort id;
        private string name;
        private double monthlySalary;
        private OurAddress address;
        private Date date;

        public ushort Id
        {
            get { return this.id; }
            set { 
                if (value > 0 && value <= 300)
                {
                    this.id = value;
                }
                else
                {
                    id = 0;
                }
            }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name= value; }
        }

        public double MonthlySalary
        {
            get { return this.monthlySalary; }
            set { this.monthlySalary = value; }
        }


        public OurAddress Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        public Date Date
        {
            get { return this.date; }
            set { this.date = value; }
        }
        public double YearlySalary()
        {
            return this.MonthlySalary * 12;
        }

        public void YearlySalaryStructure()
        {
            double yearlySalary = this.YearlySalary();
            Console.WriteLine("--Yearly Salary Breakdown--");
            
            Console.WriteLine("Yearly Salary: {0}", yearlySalary);
            Console.WriteLine("50% Basic Salary: {0}", yearlySalary * .5);
            Console.WriteLine("30% House Rent: {0}", yearlySalary * .3);
            Console.WriteLine("15% Medical Allowance: {0}", yearlySalary * .15);
            Console.WriteLine("5% Cell Phone Bill: {0}", yearlySalary * .05);
        }

        public Employee()
        {
        }

        public Employee(ushort id, string name, double monthlySalary, OurAddress address,Date date)
        {
            this.Id = id;
            this.Name = name; 
            this.MonthlySalary = monthlySalary;
            this.Address = address;
            this.Date = date;
        }

        public void ShowEmployeeInfo()
        {
            Console.WriteLine("Employee's ID: {0}", this.Id); 
            Console.WriteLine("Employee's Name: {0}", this.Name);        
            Console.WriteLine("Employee's Monthly Salary: {0}", this.MonthlySalary);
            this.Address.ShowAddress();
            this.Date.ShowDate();

            this.YearlySalaryStructure();

        }
    }
}
