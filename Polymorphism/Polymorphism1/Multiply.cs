using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polymorphism1
{
    public class Multiply
    {
        public double Multiplynum(int num1)
        {
            return num1*num1;
        }
        public double Multiplynum(int num1,int num2)
        {
            return num1*num2;
        }
        public double Multiplynum(int num1,int num2,int num3)
        {
            return num1*num2*num3;
        }
        public double Multiplynum(int num1,double num2)
        {
            return num1*num2;
        }
        public double Multiplynum(int num1,double num2,int num3)
        {
            return num1*num2*num3;
        }
    }
}