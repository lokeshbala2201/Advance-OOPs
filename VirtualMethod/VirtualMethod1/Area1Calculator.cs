using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace VirtualMethod1
{
    public class  Area1Calculator
    {
        public int Radius { get; set; }

        public AreaCalculator(int radius)
        {
            Radius=radius;
        }

        public virtual double Calculate()
        {
            return 3.14 *Radius*Radius;
        }
        public virtual void  Show()
        {
            Console.WriteLine(Calculate());
        }
    }
}