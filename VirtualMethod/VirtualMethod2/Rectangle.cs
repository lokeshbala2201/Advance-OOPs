using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualMethod2
{
    public class Rectangle : Dimention
    {
        public int Length { get; set; }
        public int Height { get; set; }

        public Rectangle(int value1,int value2,int length,int height):base( value1, value2)
        {
            Length=length;
            Height=height;
        }
        public override double Calculate()
        {
            return Area=Length* Height;
        }
        public override void Display()
        {
            Console.WriteLine($"Rectangular : {Calculate()}");
        }

    }
}