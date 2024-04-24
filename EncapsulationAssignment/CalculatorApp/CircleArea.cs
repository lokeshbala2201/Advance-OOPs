using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using MathsLib;

namespace CalculatorApp
{
    public class CircleArea:Maths
    {
        protected int radius1;
        public int Radius { get{return radius1;} set{radius1=value;} }
        internal double Area { get; set; }

        public double CalculateCircleArea()
        {
            Area=PI*radius1*radius1;
            return Area;
        
        }
        public CircleArea(int radius)
        {
            radius1=radius;
        }
        
    }
}