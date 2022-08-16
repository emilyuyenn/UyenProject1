using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Uyen_Assignment_05
{
    class Company
    {
        List<Vehicle> VehicleList;


        public Company()
        {
            this.VehicleList = new List<Vehicle>();
        }
        public void SetVehicle(List<Vehicle> vehiclelist)
        {
            this.VehicleList = vehiclelist;
        }
        public List<Vehicle>  GetVehicles()
        { return this.VehicleList; }

        public static List<Vehicle> ReadData(string path)
        {
            int listSize;
            Vehicle vehicle;
            List<Vehicle> ResultList = new List<Vehicle>();
            using (StreamReader sr = new StreamReader(path))
            {
                listSize = int.Parse(sr.ReadLine());
                for (int i = 0; i < listSize; i++)
                {
                    int type = int.Parse(sr.ReadLine());
                    String licencePlate = sr.ReadLine();
                    String driverName = sr.ReadLine();
                    String branch = sr.ReadLine();
                    int tempSlotOrCapacity = int.Parse(sr.ReadLine());


                    if (type == 1)
                    {
                        vehicle = new Motorbike(type, licencePlate, driverName, branch);
                    }
                    else if (type == 2)
                    {
                        vehicle = new Car(type, licencePlate, driverName, branch, tempSlotOrCapacity);
                    }
                    else
                    {
                        vehicle = new Truck(type, licencePlate, driverName, branch, tempSlotOrCapacity);
                    }


                    ResultList.Add(vehicle);
                }
                return ResultList;
            }
        }

        //public static void OutputVehicleList(List<Vehicle> VehicleList, string path)
        //{
        //    foreach (Vehicle s in VehicleList)
        //    {
        //        Console.WriteLine(s);
        //    }
        //}
        public void RandomLocationVehicleList()
        {
            for (int i = 0; i < VehicleList.Count; i++)
            { VehicleList[i].RandomGPS(); }
            
        }

        public void RandomStatusVehicleList()
        {
            for (int i = 0; i < VehicleList.Count; i++)
            { VehicleList[i].RandomStatus(); }

        }

        
        public double CalculateDistance(GPS gpsstart, GPS gpsdestination)
        {
            double x1 = gpsstart.GetX(), x2 = gpsdestination.GetX();
            double y1 = gpsstart.GetY(), y2 = gpsdestination.GetY();
            double distance = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));

            return distance;
        }

        public int NearestVehicle(GPS startGPS, GPS destinationGPS,
            int typecondition, int seat, int capacity)
        {
            int index = -1;
            double mindistance = double.MaxValue;
            
            for (int i = 0; i < VehicleList.Count; i++)
            {
                
                if (VehicleList[i].GetIsFree() == true)
                {
                    double distance = CalculateDistance(VehicleList[i].GetCurrentGPS(),
                    startGPS);
                    if (VehicleList[i].GetType() == typecondition && typecondition == 3)
                    {
                        //Console.WriteLine(typecondition);
                        Truck truck = (Truck)VehicleList[i];
                        if (truck.GetCapacity() == capacity && distance < mindistance)
                        {
                            mindistance = distance;
                            index = i;

                        }
                    }
                    else if (VehicleList[i].GetType() == typecondition && typecondition == 2)
                    {
                        Car car = (Car)VehicleList[i];
                        if (car.GetSeat() == seat && distance < mindistance)
                        {
                            mindistance = distance;
                            index = i;

                        }
                    }
                    else
                    {
                        if (VehicleList[i].GetType() == typecondition && typecondition == 1)
                            if (distance < mindistance)
                        {
                            mindistance = distance;
                            index = i;
                        }
                    }


                }
            

        
            }
            return index;
        }

        public double CalculateTime(Vehicle selectedVehicle, GPS gpsstart)
        {

            double km = this.CalculateDistance(selectedVehicle.GetCurrentGPS(), 
                gpsstart);

            double v = selectedVehicle.GetRandomVelocity();
            //Console.WriteLine("velocity: {0}",v);
            //Console.WriteLine("km: {0}",km);

            double time = km / v *60;

            return time;
        }
    }
}

