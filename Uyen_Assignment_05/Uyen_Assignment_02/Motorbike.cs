using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Uyen_Assignment_05
{
    internal class Motorbike : Vehicle
    {
        private int capacity = 0;
       
        public Motorbike(int type, string licenseplate, string drivername, string brand) : base(type,
            licenseplate, drivername, brand)
        {
            this.type = type;
            this.licenseplate = licenseplate;
            this.drivername = drivername;
            this.brand = brand;
            this.capacity = capacity;
        }
        public Motorbike() : base()
        {

        }

        public override double CalculateFreight(double km)
        {
            double freight;
            if (km < 2)
            { 
                freight = 15000;

            }
            else
            {
                freight = 15000 + 5000 * (km - 2);
            }

            return freight;
        }
        public override string ToString()
        {
            return "\n" + "Motorbike" + base.ToString() + "\n" ;
        }


    }
}
