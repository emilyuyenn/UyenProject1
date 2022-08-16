using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyen_Assignment_05
{
    internal class Car : Vehicle
    {
        private int seat;

        public Car(int type, string licenseplate, string drivername, string brand ,int seat) : base (type, 
            licenseplate,drivername , brand)
        {
            this.seat = seat;
        }
        public Car() : base()
        {

        }
        public void SetSeat()
        {
            this.seat = seat;
        }
        public int GetSeat()
        {
            return this.seat;
        }
        public override double CalculateFreight(double km)
        {
            double freight;
            double maxfrt;
            if (this.seat == 4)
            {
    
                freight = 50000;
                maxfrt = freight;
                freight = km * 15000;
                if (freight > maxfrt)
                    maxfrt = freight;


            }
            else
            {
                if (this.seat == 7)
                {

                    freight = 80000;
                    maxfrt = freight;
                    freight = km * 20000;
                    if (freight > maxfrt)
                        maxfrt = freight;
                }
                else
                {
                    if (this.seat == 9)
                    {

                        freight = 100000;
                        maxfrt = freight;
                        freight = km * 30000;
                        if (freight > maxfrt)
                            maxfrt = freight;
                    }
                    else
                    {

                        freight = 120000;
                        maxfrt = freight;
                        freight = km * 40000;
                        if (freight > maxfrt)
                            maxfrt = freight;
                    }
                }

            }
            
                

            return maxfrt;
        }
        public override string ToString()
        {
            return "\n"+"Car" + base.ToString() + "\n" + seat + "\n";
        }
    }
}
