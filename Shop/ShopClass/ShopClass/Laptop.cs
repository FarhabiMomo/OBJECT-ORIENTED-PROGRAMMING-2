using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopClass
{
   internal class Laptop: ProductClass
    {
        private int memorySize;
        private double clockSpeed;
        private double batteryLifetime;

        internal  int MemorySize
        {
            get { return this.memorySize; }
            set { this.memorySize = value; }
        }

        internal double ClockSpeed
        {
            get { return this.clockSpeed; }
            set { this.clockSpeed = value; }
        }

        internal double BatteryLifetime
        {
            get { return this.batteryLifetime; }
            set { this.batteryLifetime = value; }
        }

        internal Laptop(int id,double quantity, double price, ProductDate productdate, string manufectureName,int memorySize,double clockSpeed,double batteryLifetime) : base(id,quantity,price,productdate, manufectureName)
        {
            this.MemorySize = memorySize;
            this.ClockSpeed = clockSpeed;
            this.BatteryLifetime = batteryLifetime;

        }
        internal  void ShowLaptopInfo()
        {
            base.ShowInfo();
            Console.WriteLine("memorySize: {0}\n", this.MemorySize);
            Console.WriteLine("ClockSpeed: {0}\n", this.ClockSpeed);
            Console.WriteLine("BatteryLifetime: {0}\n", this.BatteryLifetime);
        }

    }
}
