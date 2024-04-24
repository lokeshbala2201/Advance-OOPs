using System;
using System.Runtime.InteropServices;
namespace Abstract1;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Cylinder");
        Cylinders cylinders=new Cylinders(5,2,3);
        Console.WriteLine(cylinders.CalculateArea());
        Console.WriteLine(cylinders.CalculateVolume());

        Console.WriteLine("Cube");
        Cubes cubes=new Cubes(5);
        Console.WriteLine(cubes.CalculateArea());
        Console.WriteLine(cubes.CalculateVolume());




    }
}