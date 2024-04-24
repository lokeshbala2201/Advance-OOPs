using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SealedClass4
{
    public class CircleCalculator:Calculator
    {
        public sealed override void Area(int radius)
        {
            System.Console.WriteLine($"Area : {3.14*radius*radius}");
        }
    }
}