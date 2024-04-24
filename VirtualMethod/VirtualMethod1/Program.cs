using System;
using VirtualMethod1;
namespace VirtualMathod1;
class Program
{
    public static void Main(string[] args)
    {
        VolumeCalculator volume=new VolumeCalculator(22,12);
        volume.Calculate();
        volume.Show();
        AreaCalculator area=new AreaCalculator(22);
        area.Calculate();
        area.Show();
    }
}