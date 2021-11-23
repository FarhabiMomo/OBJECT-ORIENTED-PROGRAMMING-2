using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubClass
{
    struct ManufectureDate
    {
        int date;
        string month;
        int year;

        public ManufectureDate(int date, string month, int year)
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
        private ManufectureDate manufectureDate;
        private double price;

        public int GetId()
        {
            return this.id;
        }
        public void SetId(int id)
        {
            if (id <= 0 && id >= 100000)
                this.id = id;
            else
                id = -1;
                //Console.WriteLine("the id is not in the range");
        }

        public string GetName()
        {
            return this.name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public ManufectureDate GetManufectureDate()
        {
            return this.manufectureDate;
        }
        public void SetManufectureData(ManufectureDate manufectureDate)
        {
            this.manufectureDate = manufectureDate;
        }
        public double GetPrice()
        {
            return this.price;
        }
        public void SetPrice(double price)
        {
                this.price = price;
        }

        public GroceryProduct()
        { }
        public GroceryProduct(int id,string name, ManufectureDate manufectureDate,double price )
        {
            this.SetId(id);
            this.name = name;
            this.manufectureDate = manufectureDate;
            this.price=price;
        }
        public void ProductInfo()
        {
            Console.WriteLine("Show All the ProductInfo");
            Console.WriteLine("id: {0}", this.id);
            Console.WriteLine("name: {0}", this.name);
            Console.WriteLine("manufectureDate: {0}", this.manufectureDate);
            Console.WriteLine("price: {0}", this.price);
            Console.WriteLine("  ");


        }
    }
}
