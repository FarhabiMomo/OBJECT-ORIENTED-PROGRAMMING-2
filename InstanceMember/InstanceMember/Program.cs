using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceMember
{
    //instance member belongs to object and static member belongs to the class.
    class Student {
        public byte rollNo;//instance varibale
        public string firstName;
        public string lastName;
        public char section;
        public static string schoolName = "ABC School";//static variable
        public static ushort fees = 4000;
        public static ushort feeIncerment = 4000;

        //instance method
        //instance method e static &instance variable both can be applicable
        public void PrintFullName()
        {
            string fullName = this.firstName + " " + this.lastName;
            Console.WriteLine("{0}",fullName);//placeholder
            Console.WriteLine("{0}",schoolName);

        }
        //static method use static keyword
        //static method e static varible applical not applicable instance variable.

        public static ushort getFees(){
            return fees;
            }
        /*here in the class Student i use variable data types ushort in vriable name freeIncrement
        but method getFreeAniualIncrement  i use int types and my result is correct no error show*/
        public static int getFeesAnnualIncrement()
        {
            return feeIncerment / 10;
        }
        public static int getFeesAnnualIncrementExta(int fees)
        {
            return fees / 10;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student Ali = new Student();//dynamic class
            Ali.rollNo = 22;
            Ali.firstName = "Jahan";
            Ali.lastName = "Ali";
            Ali.section = 'A';
            Student Ram = new Student();
            Ram.rollNo = 21;
            Ram.firstName = "jattiya";
            Ram.lastName = "Ram";
            Ram.section = 'A';
           // Console.WriteLine(Ali.rollNo + " " + Ram.rollNo);
           Console.WriteLine( Ali.rollNo+" " +Ali.firstName+ " "+ Ali.lastName+" "+ Ali.section);
            Ali.PrintFullName();
            Console.WriteLine("{0}",Student.schoolName);
            Console.WriteLine("{0}", Student.getFees());
            Console.WriteLine("{0}", Student.getFeesAnnualIncrement());
            Console.WriteLine("{0}", Student.getFeesAnnualIncrementExta(3000));

            Console.WriteLine(Ram.rollNo + " " + Ram.firstName + " " + Ram.lastName + " " + Ram.section);
            Ram.PrintFullName();
            Console.WriteLine("{0}", Student.schoolName);
            Console.WriteLine("{0}", Student.getFees());
            Console.WriteLine("{0}", Student.getFeesAnnualIncrement());
            Console.WriteLine("{0}", Student.getFeesAnnualIncrementExta(3000));
            //placeholder
            byte u = 12;
            byte b = 34;
            string name = "momo";
            Console.WriteLine("{0},{1},{2}",u,b,name);
            //take user input
            Console.WriteLine("enter the string number");
            Console.WriteLine("Output:{0}", Console.ReadLine());
            //convertion int
            Console.WriteLine("enter the integer number");
            string tx = Console.ReadLine();
            int t = Convert.ToInt32(tx);
            Console.WriteLine("output:{0}", t);
            //convertion int(another way)
            Console.WriteLine("enter the integer number");
            int e = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("output:{0}", Convert.ToInt32(Console.Read(e))); error
            Console.WriteLine("output:{0}", e);
            //float & double
            float f = 23.54f;// before using F show error becuase source(23.54(defult double)) and destination(f(float)) are n't same type.
            double d = 34.45;
            Console.WriteLine("output:{0},{1}", f,d);

            //typeCasting


        }
    }
}
