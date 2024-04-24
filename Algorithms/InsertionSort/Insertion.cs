using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsertionSort
{
    public static class Insertion
    {
        //acsending
        //int array
        public static void Sort(int[] array)
        {
            for(int i =1;i<array.Length;i++)
            {
                int value=array[i];
                int j=i-1;
                while(j>=0 && array[j]>value)
                {
                    array[j+1]=array[j];
                    j=j-1;
                }
                array[j+1]=value;
            }

        }
        //double array
        public static void Sort(double[] array)
        {
            for(int i =1;i<array.Length;i++)
            {
                double value=array[i];
                int j=i-1;
                while(j>=0 && array[j]>value)
                {
                    array[j+1]=array[j];
                    j=j-1;
                }
                array[j+1]=value;
            }

        }
        //char array
        public static void Sort(char[] array)
        {
            for(int i =1;i<array.Length;i++)
            {
                char value=array[i];
                int j=i-1;
                while(j>=0 && array[j]>value)
                {
                    array[j+1]=array[j];
                    j=j-1;
                }
                array[j+1]=value;
            }

        }
        //string array
        public static void Sort(string[] array)
        {
            for(int i =1;i<array.Length;i++)
            {
                string value=array[i];
                int j=i-1;
                while(j>=0 && array[j].CompareTo(value)>0)
                {
                    array[j+1]=array[j];
                    j=j-1;
                }
                array[j+1]=value;
            }

        }
        //ascending order
        //int array
        public static void Sort(int[] array,int x)
        {
            if(x==-1){
            for(int i =1;i<array.Length;i++)
            {
                int value=array[i];
                int j=i-1;
                while(j>=0 && array[j]>value)
                {
                    array[j+1]=array[j];
                    j=j-1;
                }
                array[j+1]=value;
            }
            }

        }
        //double array
        public static void Sort(double[] array,int x)
        {
            if(x==-1){
            for(int i =1;i<array.Length;i++)
            {
                double value=array[i];
                int j=i-1;
                while(j>=0 && array[j]>value)
                {
                    array[j+1]=array[j];
                    j=j-1;
                }
                array[j+1]=value;
            }
            }

        }
        //char array
        public static void Sort(char[] array,int x)
        {
            if(x==-1){
            for(int i =1;i<array.Length;i++)
            {
                char value=array[i];
                int j=i-1;
                while(j>=0 && array[j]>value)
                {
                    array[j+1]=array[j];
                    j=j-1;
                }
                array[j+1]=value;
            }
            }

        }
         public static void Sort(string[] array,int x)
        {
            if(x==-1){
            for(int i =1;i<array.Length;i++)
            {
                string value=array[i];
                int j=i-1;
                while(j>=0 && array[j].CompareTo(value)<0)
                {
                    array[j+1]=array[j];
                    j=j-1;
                }
                array[j+1]=value;
            }
            }

        }
        
    }
}