using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualMethod2
{
    public class Dimention
    {
        public int Value1 { get; set; }
        public int Value2 { get; set; }
        public double Area { get; set; }

        public Dimention(int value1,int value2)
        {
            Value1=value1;
            Value2=value2;
        }
        public virtual double Calculate()
        {
           return Area=Value1* Value2;
          
        }
        public virtual void Display()
        {
            Console.WriteLine($"Dimension : {Calculate()}");
        }
    }
}