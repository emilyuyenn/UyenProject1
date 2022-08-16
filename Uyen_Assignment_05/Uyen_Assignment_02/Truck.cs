using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyen_Assignment_05
{
    internal class Truck : Vehicle
    {
        private int capacity;

        public Truck(int type, string licenseplate, string drivername, string brand, int capacity) : base(type,
            licenseplate, drivername, brand)
        {
            this.capacity = capacity;
        }
        public Truck() : base()
        {
            
        }
        public void SetCapacity()
        {
            this.capacity = capacity;
        }
        public int GetCapacity()
        { return this.capacity; }
        public override double CalculateFreight(double km)
        {
            double freight;
            
            if (km <= 5)
            {
                if (this.capacity < 1500)
                {
                    freight = 350000 * km;
                    return freight;
                }
                else
                {
                    if (this.capacity >= 1500 && this.capacity <= 2500)
                    {
                        freight = 450000 * km;
                        return freight;
                    }
                    else
                    {
                        freight = 550000 * km;
                        return freight;
                    }
                }
            }
            else 
            {
                if (km > 5 && km < 40 )
                {
                    if (this.capacity < 1500)
                    {
                        freight = 350000 * 5 + (km-5)*20000;
                    }
                    else
                    {
                        if (this.capacity >= 1500 && this.capacity <= 2500)
                        {
                            freight = 450000 * 5 + (km - 5) * 25000;
                        }
                        else
                        {
                            freight = 550000 * 5 + (km - 5) * 30000;
                        }
                    }
                }
                else
                {
                    if (this.capacity < 1500)
                    {
                        freight = 350000 * 5 + 20000 * (40 - 5) + (km - 40) * 15000;
                    }
                    else
                    {
                        if (this.capacity >= 1500 && this.capacity <= 2500)
                        {
                            freight = 450000 * 5 +  25000 * (40 - 5) + (km - 40) * 20000;
                        }
                        else
                        {
                            freight = 550000 * 5 + 30000 * (40 - 5) + (km - 40) * 25000;
                        }
                    }
                }

            }
            
            return freight;

        }
        public override string ToString()
        {
            return "\n" + "Truck" + base.ToString() + "\n" + capacity + "\n" ;
        }
    }
}
