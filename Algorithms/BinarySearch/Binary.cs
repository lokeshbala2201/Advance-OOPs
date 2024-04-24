using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BinarySearch
{
    public static class Binary
    {
        public static bool Search(int[] array, int element)
        {
            
            int min=0;
            int max=array.Length-1;
            while(min<=max)
            {
                int mid=min+max/2;
                if(element==array[mid])
                {
                   return true; 
                }else if(element<array[mid])
                {
                    max=mid-1;
                }else if(element>array[mid])
                {
                    min=mid+1;
                }
            }
            return false;
            
        }
        //double array
        public static bool Search(double[] array, double element)
        {
            Array.Sort<double>(array);
            int min=0;
            int max=array.Length-1;
            while(min<=max)
            {
                int mid=min+max/2;
                if(element==array[mid])
                {
                   return true; 
                }else if(element<array[mid])
                {
                    max=mid-1;
                }else if(element>array[mid])
                {
                    min=mid+1;
                }
            }
            return false;
            
        }
        //char array
        public static bool Search(char[] array, char element)
        {
            Array.Sort<char>(array);
            
            int min=0;
            int max=array.Length-1;
            while(min<=max)
            {
                int mid=(min+max)/2;
                if(element==array[mid])
                {
                   return true; 
                }else if(element<array[mid])
                {
                    max=mid-1;
                }else if(element>array[mid])
                {
                    min=mid+1;
                }
            }
            return false;
            
        }
        //string array
        public static bool Search(string[] array, string element)
        {
            Array.Sort<string>(array);
          
            int min=0;
            int max=array.Length-1;
            while(min<=max)
            {
                int mid=(min+max)/2;
                if(element==array[mid])
                {
                   return true; 
                }else if(element.CompareTo(array[mid])<0)
                {
                    max=mid-1;
                }else if(element.CompareTo(array[mid])>0)
                {
                    min=mid+1;
                }
            }
            return false;
            
        }
    }
}