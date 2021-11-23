using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ShopClass
{
    internal class CannedFood:ProductClass
    {
        private int expireDate;

        internal int ExpireDate
        {
            get { return this.expireDate; }
            set { this.expireDate = value; }
        }

        internal CannedFood(int id, double quantity, double price, ProductDate productdate, string manufectureName, int expireDate) : base(id, quantity, price, productdate, manufectureName)
        {
            this.ExpireDate = expireDate;
        }

        internal void ShowCannedFoodInfo()
        {
            base.ShowInfo();
            Console.WriteLine("ExpireDate: {0}\n", this.ExpireDate);
      
        }
    }
}
