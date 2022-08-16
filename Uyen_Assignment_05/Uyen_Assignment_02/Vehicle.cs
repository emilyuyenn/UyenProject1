using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyen_Assignment_05
{
    internal abstract class Vehicle
    {
        protected string licenseplate;
        protected string drivername;
        protected string brand;
        protected Boolean isfree;
        protected double velocity;
        protected int type;
        protected GPS currentGPS;

        public Vehicle(int type, string licenseplate, string drivername, string brand)
        {
            this.type = type; 
            this.licenseplate = licenseplate;
            this.drivername = drivername;
            this.brand = brand;
                      
            
        }
        public Vehicle()
        {

        }
        public void SetType()
        {
            this.type = type;
        }
        public int GetType()
        {
            return this.type;
        }
        public void GetLicensePlate()
        {
            this.licenseplate = licenseplate;
        }
        public string SetLicensePlate()
        {
            return this.licenseplate;
        }
        public void SetDriverName()
        {
            this.drivername = drivername;
        }
        public string GetDriverName()
        {
            return this.drivername;
        }
        public void SetBrand()
        {
            this.brand = brand;
        }
        public string GetBrand()
        {
            return this.brand;
        }
        public bool GetIsFree()
        {
            return isfree;
        }
        public void SetIsFree()
        {
            this.isfree = isfree;

        }
        public void SetVelocity(double velocity)
        {
             this.velocity = velocity;
        }
        public double GetVelocity()
        {
            return this.velocity;
        }
        public GPS GetCurrentGPS()
        {
            return currentGPS;

        }
        public void SetCurrentGPS(GPS currentGPS)
        {
            this.currentGPS = currentGPS;
        }
        public void RandomGPS()
        {
            Random randGPS = new Random();
            double temp;
            temp = randGPS.NextDouble();
            double x_random = (Math.Round(temp * 40) / 1d - 20);
            temp = randGPS.NextDouble();
            double y_random = (Math.Round(temp * 40) / 1d - 20);
            GPS newGPS = new GPS(x_random, y_random);

            this.SetCurrentGPS(newGPS);
        }

        public void RandomStatus()
        {
            Random random = new Random();
            this.isfree = random.Next(100) <= 50 ? true : false;
        }
        public abstract double CalculateFreight(double km);

        

        public void UpdateGPS(GPS NewGPS)
        {
            this.currentGPS = NewGPS;
            //Console.WriteLine(NewGPS.ToString());
        }
        
        public double GetRandomVelocity()
        {
            Random randvelocity = new Random();
            int velocity = randvelocity.Next(20, 80);
            this.velocity = velocity;
            return velocity;

        }
        public override string ToString()
        {
            return "\n" + licenseplate + "\n" + drivername + "\n" + brand + "\n" +"Location of Vehicle: "
                + currentGPS.GetX() +", "+currentGPS.GetY() + "\n" + isfree;

        }


    }


}

