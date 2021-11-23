using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    struct Date
    {
        int date;
        string month;
        int year;

        public Date(int date,string month,int year)
        {
            this.date = date;
            this.month = month;
            this.year = year;
        }

        public void ShowDate()
        {
            Console.WriteLine("Date Info:");
            Console.WriteLine("Date: {0}", this.date);
            Console.WriteLine("Month: {0}", this.month);
            Console.WriteLine("Year: {0}", this.year);
        }
    }
    class GroceryProduct
    {
        private int id;
        private string name;
        private Date manufectureDate;
        private double price;

        public int GetId()
        {
            return this.id;
        }
        public void SetId(int id)
        {
            if (id > 0.0 && id < 1000000)
            {
                this.id = id;
            }
            else
            {
                id = 0;
            }
        }

        public string GetName()
        {
            return this.name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public Date GetManufectureDate()
        {
            return this.manufectureDate;
        }
        public void SetManufectureData(Date manufectureDate)
        {
            this.manufectureDate = manufectureDate;
        }
        public double GetPrice()
        {
            return this.price;
        }
        public void SetPrice(double price)
        {
            if (price > 0.0 && price < 1000000)
            {
                this.price = price;
            }
            else
            {
                price = 0;
            }
        }

        public GroceryProduct()
        { }
        public GroceryProduct(int id, string name, Date manufectureDate, double price)
        {
            this.SetId(id);
            this.name = name;
            this.SetManufectureData(manufectureDate);
            this.SetPrice(price);
        }
        public void ProductInfo()
   
     {
            Console.WriteLine("Show All the ProductInfo");
            Console.WriteLine("Product Id: {0}", this.id);
            Console.WriteLine("Product Name: {0}", this.name);
            this.manufectureDate.ShowDate();
            Console.WriteLine("Product Price: {0}", this.price);
            Console.WriteLine("  ");


        }
    }
}