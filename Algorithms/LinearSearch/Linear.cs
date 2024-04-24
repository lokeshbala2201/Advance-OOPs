using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinearSearch
{
    //int array
    public static class Linear
    {
        public static bool Search(int[] array,int element)
        {
            for(int i=0;i<array.Length;i++)
            {
                if(element==array[i])
                {
                    return true;
                }
            }
            return false;
        }
        //binary array
        public static bool Search(double[] array,double element)
        {
            for(int i=0;i<array.Length;i++)
            {
                if(element==array[i])
                {
                    return true;
                }
            }
            return false;
        }
        //char array
        public static bool Search(char[] array,char element)
        {
            for(int i=0;i<array.Length;i++)
            {
                if(element==array[i])
                {
                    return true;
                }
            }
            return false;
        }
        //string array'
        public static bool Search(string[] array,string element)
        {
            for(int i=0;i<array.Length;i++)
            {
                if(element==array[i])
                {
                    return true;
                }
            }
            return false;
        }

    }
}