using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Date d = new Date(23, "jun", 2017);
            Date d1 = new Date(21, "july", 2011);
            Employee employeeOne = new Employee();
            employeeOne.Id = 1; 
            employeeOne.Name = "Farah";                                  
            employeeOne.MonthlySalary = 2500; 
            employeeOne.Address = new OurAddress(397,"Road-7, Block-F", "Dhaka");
            employeeOne.Date=d;
            Employee employeeTwo = new Employee(2, "Momo", 1000, new OurAddress(23, "Jamidar Bari", "Khulna"),d1);

            employeeTwo.ShowEmployeeInfo();

        }
    }
}