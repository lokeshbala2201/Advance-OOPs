using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SealedClass4
{
    public abstract class Calculator
    {
        public abstract void Area(int radius);
        public  double Volume(int radius)
        {
            return 3.14*radius*radius;
        }
    }
}