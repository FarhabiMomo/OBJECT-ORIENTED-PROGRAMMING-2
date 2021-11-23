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
            GroceryProduct productOne = new GroceryProduct();
            productOne.SetId(100);
            productOne.SetName("Farhabi");
            productOne.SetManufectureData("1234ds");
            productOne.SetPrice(132);
            productOne.ProductInfo();

           GroceryProduct producttwo = new GroceryProduct(100,"Farhabi","1234ds",132);
            producttwo.ProductInfo();
        }
    }
}
