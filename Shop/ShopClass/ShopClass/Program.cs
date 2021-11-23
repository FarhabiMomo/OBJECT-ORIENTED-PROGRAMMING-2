using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopClass
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductClass pc = new ProductClass(1,868, 97,new ProductDate(2, "May", 1998), "hazi");
            pc.ShowInfo();

            CannedFood cf = new CannedFood(1, 868, 97, new ProductDate(2, "May", 1998), "hazi",43);
            cf.ShowCannedFoodInfo();

            Laptop l = new Laptop(1, 868, 97, new ProductDate(2, "May", 1998), "hazi",43,12,34);
            l.ShowLaptopInfo();
        }
    }
}
