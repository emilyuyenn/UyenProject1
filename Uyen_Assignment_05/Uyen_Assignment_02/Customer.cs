using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyen_Assignment_05
{
    internal class Customer
    {
        GPS currentGPS;
        GPS startGPS;
        GPS destinationGPS;
        public Customer(GPS startGPS, GPS destinationGPS)
        {
            
            this.startGPS = startGPS;
            this.destinationGPS = destinationGPS;
        }
        public Customer()
        {
            this.currentGPS = new GPS();
        }
        public Customer(GPS currentGPS) 
        {
            this.currentGPS = currentGPS;
        }
        public GPS GetCurrentGPS()
            { return this.currentGPS; }
        public void SetCurrentGPS()
        { this.currentGPS = currentGPS; }
        public GPS GetStartGPS()
            { return this.startGPS; }
        public void SetStartGPS()
            { this.startGPS = startGPS;  }
        public GPS GetDestinationGPS()
        { return this.destinationGPS; }
        public void SetDestinationGPS()
        { this.destinationGPS = destinationGPS; }

        public void BookVehicle(Company company)
        {
            int seat = 0, capacity = 0; 
            Vehicle bookedVehicle;
            
            Console.WriteLine("Select type of Vehicle 1. Motorbike, 2. Car, 3. Truck ");
            int option = int.Parse(Console.ReadLine());
            {
                if (option == 3)
                {
                    Console.WriteLine("Please input capacity: ");
                    capacity = int.Parse(Console.ReadLine());
                }
                else
                {
                    if (option == 2)
                    {
                        Console.WriteLine("Please select seat (4 , 7 , 9, 16): ");
                        seat = int.Parse(Console.ReadLine());

                    }
                    else
                    {
                        Console.WriteLine("Next step: ");
                    }
                }
                Console.WriteLine("Enter started point: ");
                double startX = double.Parse(Console.ReadLine());
                double startY = double.Parse(Console.ReadLine());
                startGPS = new GPS(startX,startY);
                Console.WriteLine("Enter Destination point: ");
                double desX = double.Parse(Console.ReadLine());
                double desY = double.Parse(Console.ReadLine());
                destinationGPS = new GPS(desX, desY);

                double km = company.CalculateDistance(startGPS,destinationGPS);
                int bookedVehicleIndex = company.NearestVehicle(startGPS,destinationGPS,option, 
                    seat, capacity);
                if(bookedVehicleIndex == -1)
                {
                    Console.WriteLine("Oops! No vehicle meet your require");
                }
                else
                {
                    bookedVehicle = company.GetVehicles()[bookedVehicleIndex];
                    double time = company.CalculateTime(bookedVehicle,
                        this.startGPS);
                    double freight = bookedVehicle.CalculateFreight(km);
                    bookedVehicle.UpdateGPS(destinationGPS);
                    Console.WriteLine("Driver is coming to your location!");
                    Console.WriteLine("This is your trip information:");
                    Console.WriteLine(bookedVehicle.ToString());
                    
                    Console.WriteLine("Time: {0} minutes",Math.Round(time,2));
                    Console.WriteLine("Freight: {0} VND",Math.Round(freight, 0));

                }
            }
        }
        

        public GPS InputGPS()
        {
            GPS gps = new GPS();
            Console.WriteLine("Enter X, Y: ");
            double X = double.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine());
            GPS newGPS = new GPS(X, Y);


            return newGPS;
            
        }

      
    }
}
