using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Account a = new Account();
            //SavingsClass s = new SavingsClass(40);
            //Console.WriteLine();
            //a.M1();
            //s.M1();

            //Console.WriteLine();
            //a.M1();

            //Account a = new Account(2, "Momo", new MyDate(23, "Jamidar Bari", 1245)," a+");
            //a.ShowAccountInfo();
            //SavingsClass sc = new SavingsClass(2, "Momo", new MyDate(23, "Jamidar Bari", 1245), " a+",3.89);
            //sc.ShowSvaingInfo();
            //CurrentAccount ca = new CurrentAccount(2, "Momo", new MyDate(23, "Jamidar Bari", 1245), " a+", 36543);
            //ca.ShowCurrentInfo();

            // Account[] a = new Account[5];
            // a[0] =new SavingsClass(2, "Momo", new MyDate(1, "Bari", 1245), " A+",3.98);
            //a[1] = new CurrentAccount(2, "Rahi", new MyDate(2, "raja Bari", 5343), " B+",3.78);
            //a[2] = new SavingsClass(3, "Shila", new MyDate(3, "hazipur", 43432), " O+",67000);

            // int count = 0;
            // while(count>a.Length)
            // {
            // a[count].ShowAccountInfo();
            // count++;

            FinsncialAccount.AddPerson(new SavingsAccount("Bruce", new MyDate(2, "May", 1998),new OurAddress(1,"2F-Banani","Dkhaka","Bangladesh"),43,21));
            FinsncialAccount.AddPerson(new CurrentAccount("naina", new MyDate(2, "May", 1998), new OurAddress(2, "3A-mahammadpur", "Dhaka", "Bangladesh"), 43,45));
            FinsncialAccount.AddPerson(new Loan("jon", new MyDate(2, "May", 1998), new OurAddress(3, "4B-Napitarpul", "Noakhali", "Bangladesh"), 23, 23));
            //xyz.ShowAll();

            int id;
            FinsncialAccount.ShowAll();
            FinsncialAccount.SearchIndividual("A-1-S",out id);
            FinsncialAccount.DeletePerson("A-1-C");
            
        }
        }
    }

