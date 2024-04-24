using System;
namespace SealedClass4;
class Program
{
    public static void Main(string[] args)
    {
        CircleCalculator circle=new CircleCalculator();
        circle.Area(5);
        Console.WriteLine(circle.Volume(5));

        CylinderCalculator cylinder= new CylinderCalculator();
        cylinder.Area(3);
        Console.WriteLine(cylinder.Volume(2));
    }
}
