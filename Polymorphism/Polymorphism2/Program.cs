using System;
using Polymorphism2;
namespace Polymorphism;
class Program
{
    public static void Main(string[] args)
    {
        Square square=new Square();
        Console.WriteLine(square.Squarenum(2));
        Console.WriteLine(square.Squarenum(5.2457586747));
        Console.WriteLine(square.Squarenum(2.25));
        Console.WriteLine(square.Squarenum(24637552352735));
    }
}
