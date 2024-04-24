using System;
using VirtualMethod2;
namespace VirtualMethod1;
class Program
{
    public static void Main(string[] args)
    {
        Dimention dimention=new Dimention(25,2);
        dimention.Display();
        Rectangle rectangle=new Rectangle(dimention.Value1,dimention.Value2,5,5);
        rectangle.Display();
        Sphere sphere=new Sphere(dimention.Value1,dimention.Value2,10);
        sphere.Display();
    }
}
