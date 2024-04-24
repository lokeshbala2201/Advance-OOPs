using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultilpeInheritance2
{
    public class Car
    {
        public string  FuelType { get; set; }
        public int NumberOfSeats { get; set; }
        public string Color { get; set; }
        public int TankCapacity { get; set; }
        public int NumberOfKmDriven { get; set; }

        public Car(string fuelType,int seats,string color,int tankcapacity,int numberofKmDriven)
        {
            FuelType=fuelType;
            NumberOfSeats=seats;
            Color=color;
            TankCapacity=tankcapacity;
            NumberOfKmDriven=numberofKmDriven;
        }

        public double CalculateMilage()
        {
            return NumberOfKmDriven/TankCapacity; 
        }
    }
}