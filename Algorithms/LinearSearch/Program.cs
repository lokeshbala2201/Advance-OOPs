﻿using System;
namespace LinearSearch;
class Program
{
    public static void Main(string[] args)
    {
        int[] intArray=new int[] {45,33,12,55,77,66,22,33,14,67,12,35};
        char[] charArray=new char[]{'c','a','f','b','k','h','z','t','m','p','l','d'};
        double[] doubleArray=new double[]{1.1,65.3,93.9,55.5,3.5,6.9};
        string[] stringArray =new string[]{"SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092"};

        Console.WriteLine(Linear.Search(intArray,66));
        Console.WriteLine(Linear.Search(charArray,'m'));
        Console.WriteLine(Linear.Search(stringArray,"SF3067"));
        Console.WriteLine(Linear.Search(doubleArray,3.5));
    }
}