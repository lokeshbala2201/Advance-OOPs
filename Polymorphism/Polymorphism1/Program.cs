using System;
using Polymorphism1;
namespace Polymorphism
{
    class Program
    {
        public static void Main(string[] args)
        {
            Multiply mul=new Multiply();
            Console.WriteLine(mul.Multiplynum(2));
            Console.WriteLine(mul.Multiplynum(2,2));
            
            Console.WriteLine(mul.Multiplynum(2,5,7));
            
            Console.WriteLine(mul.Multiplynum(2,4.0));
            mul.Multiplynum(2,4.0);
            Console.WriteLine(mul.Multiplynum(2,3.0,5));
            
            Console.WriteLine(mul.Multiplynum(2,3.0,5));
        
            Console.WriteLine();
        }
    }
}