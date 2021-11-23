using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_day4_
{
    struct points
    {
       public double x;
       public double y;
    }
    class Program
    {
        static void Main(string[] args)
        {
        points p1;
            p1.x = 23;
            p1.y = 21;

         points p2;
            p2.x = 23;
            p2.y = 21;


         points p3=new points();
            p1.x = 23;
            p1.y = 21;
            Console.WriteLine("{0},{1}", p1.x,p1.y);
        }
    }
}
