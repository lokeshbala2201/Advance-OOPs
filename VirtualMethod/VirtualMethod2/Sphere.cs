using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualMethod2
{
    public class Sphere:Dimention
    {
        public int Radius { get; set; }

        public Sphere(int value1,int value2,int radius):base(value1,value2){
            Radius=radius;
        }


        public override double Calculate()
        {
            return 4*3.14*Radius* Radius;
        }
        public override void Display()
        {
            Console.WriteLine($"Sphere : {Calculate()}");
        }
    }
}