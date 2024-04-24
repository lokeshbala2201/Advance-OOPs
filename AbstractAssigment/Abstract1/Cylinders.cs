using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract1
{
    public class Cylinders:Shape
    {
        public override double Area { get; set; }
        public override  double Volume { get; set; }
        public int Radius1 { get; set; }
        public int Height1 { get; set; }
        public int Width1 { get; set; }
     

        public Cylinders(int radius,int height,int width)
        {
            Radius1=radius;
            Height1=height;
            Width1=width;

        }
      
        public override double CalculateArea()
        {
            Area= 2*3.14+Radius1+(Radius1+Height1);
            return Area;
        }
        public override double  CalculateVolume()
        {
            Volume= 3.14*Radius1*2*Height1;
            return Math.Round(Volume,2);
        }
    }
}