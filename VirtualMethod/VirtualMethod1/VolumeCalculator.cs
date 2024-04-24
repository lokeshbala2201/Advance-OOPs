using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualMethod1
{
    public class VolumeCalculator : AreaCalculator
    {
        public int Height { get; set; }

        public VolumeCalculator(int Radius,int height):base(Radius)
        {
            Height=height;
        }

        public override double Calculate()
        {
            return 3.14 *Radius*Radius*Height;
        }


        public override void Show()
        {
            Console.WriteLine(Calculate());
        }


    }
}