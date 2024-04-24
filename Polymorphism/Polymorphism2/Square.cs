using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polymorphism2
{
    public class Square
    {
        public double Squarenum(int num1)
        {
            return num1*num1;
        }
        public double Squarenum(float num1)
        {
            return num1*num1;
        }
        public double Squarenum(double num1)
        {
            return num1*num1;
        }
        public long Squarenum(long num1)
        {
            return num1*num1;
        }

    }
}