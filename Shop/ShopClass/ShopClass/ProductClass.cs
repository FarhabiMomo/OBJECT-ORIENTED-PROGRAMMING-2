using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopClass
{
    internal struct ProductDate
    {
        private byte day;
        private string month;
        private ushort year;

        internal ProductDate(byte day, string month, ushort year)
        {
            if (day >= 1 && day <= 31)
            {
                this.day = day;
                this.month = month;
                this.year = year;
            }
            else
            {
                this.day = 1;
                this.month = "January";
                this.year = 1980;
            }
        }
        internal void ShowDate()
        {
            Console.WriteLine("Date of Birth: {0}/{1}/{2}", this.day, this.month, this.year);
        }
    }

    internal class ProductClass
    {
        private int id;
        private double quantity;
        private double price;
        private ProductDate productDate;
        private string manufactureName;

        internal int Id
        {
            get { return this.id; }
            set
            {
                this.id =  value;
            }
        }

        internal double Quantity
        {
            get { return this.quantity; }
            set
            {
                this.quantity= value;
            }
        }

        internal double Price
        {
            get { return this.price; }
            set
            {
                this.price = value;
            }
        }

        internal ProductDate ProductDate
        {
            get { return this.productDate; }
            set
            {
                this.productDate = value;
            }
        }

        internal string ManufactureName
        {
            get { return this.manufactureName; }
            set
            {
                this.manufactureName = value;
            }
        }

        internal ProductClass(int id,double quantity,double price, ProductDate productDate, string manufectureName)
        {
            this.Id = id;
            this.Quantity = quantity;
            this.Price = price;
            this.ProductDate = productDate;
            this.ManufactureName = manufectureName;
        }

        internal void ShowInfo()
        {
            Console.WriteLine("Information: ");
            Console.WriteLine("ID: {0}", this.Id);
            Console.WriteLine("Quantity: {0}", this.Quantity);
            Console.WriteLine("Price: {0}", this.Price);
            this.ProductDate.ShowDate();
            Console.WriteLine("ManufactureName: {0}", this.ManufactureName);
        }
    }
}



