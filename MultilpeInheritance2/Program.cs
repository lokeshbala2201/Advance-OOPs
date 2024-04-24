using System;
using MultilpeInheritance2;
namespace MultipleInheritance2;
class Program
{
    public static void Main(string[] args)
    {
        Car car=new Car("Petrol",6,"Red",20,120);
        ShiftDezire shiftDezire=new ShiftDezire(car.FuelType,car.NumberOfSeats,car.Color,car.TankCapacity,car.NumberOfKmDriven,"TATA","TT2468",1234,4321);
        shiftDezire.ShowDetails();
        Eco eco=new Eco(car.FuelType,car.NumberOfSeats,car.Color,car.TankCapacity,car.NumberOfKmDriven,"BenZ","BZ2448",0002,4557);
        eco.ShowDetails();
    }
}