using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyen_Assignment_05
{
    internal class GPS
    {
        private double x ;
        private double y ;

       
        public GPS(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public GPS()
        {
            this.x = 0;
            this.y = 0;
        }
        public double GetX()
            { return this.x; }
        public void SetX()
        { this.x = x; }
        public double GetY()
            { return this.y; }
        public void SetY()
        { this.y = y; }
        

        public GPS InputGPS()
        {
            
            Console.WriteLine("Enter X, Y: ");
            double X = double.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine());
            GPS newGPS = new GPS(X, Y);


            return newGPS;

        }

    }
}
