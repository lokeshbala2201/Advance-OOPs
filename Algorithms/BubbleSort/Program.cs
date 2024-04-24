using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
namespace BubbleSort;
class Program
{
    public static void Main(string[] args)
    {
        //Bubble sort 
        //ascending
        int[] intArray=new int[] {45,33,12,55,77,22,33,14,67,12,35};
        char[] charArray=new char[]{'c','a','f','b','k','h','z','t','m','p','l','d'};
        double[] doubleArray=new double[]{1.1,65.3,93.9,55.5,3.5,6.9};
        string[] stringArray =new string[]{"SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092"};

        BubbleSort.Sort(intArray);
        BubbleSort.Sort(charArray,-1);
        BubbleSort.Sort(doubleArray,-1);
        BubbleSort.Sort(stringArray,-1);

        foreach(string i in stringArray)
        {
            Console.WriteLine(i);
        }
        
    }
}
