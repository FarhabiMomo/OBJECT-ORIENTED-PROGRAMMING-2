using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Date d = new Date(23,"jun",2017);
            Date d1 = new Date(21, "july", 2011);

            GroceryProduct productOne = new GroceryProduct();
            productOne.SetId(-123);
            productOne.SetName("Farhabi");
            productOne.SetManufectureData(d);
            productOne.SetPrice(23);
            productOne.ProductInfo();
            //d.ShowDate();

             GroceryProduct producttwo = new GroceryProduct(1045, "Farhabi", d1,132);
             producttwo.ProductInfo();
        }
    }
}
