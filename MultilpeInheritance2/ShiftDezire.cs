using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultilpeInheritance2
{
    public class ShiftDezire:Car,IBrand
    {
        private static int s_makingID=1000;
        public string  CarID { get; set; }
        public int EngineNumber { get; set; }
        public int ChasisNumber { get; set; }
        public string BrandName { get; set; }
        public string ModelName { get; set; }

        public ShiftDezire(string fuelType,int seats,string color,int tankcapacity,int numberofKmDriven,string brand,string model,int engineNumber,int chasisNumber):base( fuelType,seats, color,tankcapacity,numberofKmDriven)
        {
            s_makingID++;
            CarID="CID"+s_makingID;
            ModelName=model;
            BrandName=brand;
            EngineNumber=engineNumber;
            ChasisNumber=chasisNumber;
        }

        public void ShowDetails()
        {
            System.Console.WriteLine($"Brand Name : {BrandName}\nModel Name : {ModelName}\n Model ID : {CarID}\nEngine Number : {EngineNumber}\nChasis Number : {ChasisNumber}\nFule Type : {FuelType}\nNo Of Seats : {NumberOfSeats}\nColor : {Color}\n Tank Capacity : {TankCapacity}\nNumberOfKmDriven : {NumberOfKmDriven}\nMilage : {CalculateMilage()}\n");
        }
    }
}