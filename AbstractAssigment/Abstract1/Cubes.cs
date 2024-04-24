using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract1
{
    public class Cubes:Shape
    { 
         public override double Area { get; set; }
        public override  double Volume { get; set; }
        public int Page1 { get; set; }
     

        public Cubes(int page)
        {
           
            Page1=page;
        }
      
        public override double CalculateArea()
        {
            Area=6*Page1*2;
            return Area;
        }
        public override double  CalculateVolume()
        {
            Volume=Page1*3;
            return Volume;
        }  
    }
}