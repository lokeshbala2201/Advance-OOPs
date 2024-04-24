using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SealedClass4
{
    public class CylinderCalculator:Calculator
    {
        public override void Area(int radius)
        {
            System.Console.WriteLine($"Area : {2*3.14*radius}");
        }
        public  double Volume(int radius)
        {
            return 3.14*radius*radius;
        }
    }
}