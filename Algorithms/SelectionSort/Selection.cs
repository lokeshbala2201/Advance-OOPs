using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SelectionSort
{
    public static class Selection
    {
        //ascending 
        //int array
        public static void Sort(int[] array)
        {
            for(int i=0;i<array.Length-1;i++)
            {
                int minValue=i;
                for(int j=i+1;j<array.Length;j++)
                {
                    if(array[j]<array[minValue])
                    {
                        minValue=j;
                    }
                }
                int temp=array[i];
                array[i]=array[minValue];
                array[minValue]=temp;
            }
        }
        //double array
        public static void Sort(double[] array)
        {
            for(int i=0;i<array.Length-1;i++)
            {
                int minValue=i;
                for(int j=i+1;j<array.Length;j++)
                {
                    if(array[j]<array[minValue])
                    {
                        minValue=j;
                    }
                }
                double temp=array[i];
                array[i]=array[minValue];
                array[minValue]=temp;
            }
        }
        //char array
        public static void Sort(char[] array)
        {
            for(int i=0;i<array.Length-1;i++)
            {
                int minValue=i;
                for(int j=i+1;j<array.Length;j++)
                {
                    if(array[j]<array[minValue])
                    {
                        minValue=j;
                    }
                }
                char temp=array[i];
                array[i]=array[minValue];
                array[minValue]=temp;
            }
        }
        //string array
        public static void Sort(string[] array)
        {
            for(int i=0;i<array.Length-1;i++)
            {
                int minValue=i;
                for(int j=i+1;j<array.Length;j++)
                {
                    if(array[j].CompareTo(array[minValue])<0)
                    {
                        minValue=j;
                    }
                }
                string temp=array[i];
                array[i]=array[minValue];
                array[minValue]=temp;
            }
        }
        //desecnding
        //int array
        public static void Sort(int[] array,int x)
        {
            if(x==-1){
            for(int i=0;i<array.Length-1;i++)
            {
                int maxValue=i;
                for(int j=i+1;j<array.Length;j++)
                {
                    if(array[j]>array[maxValue])
                    {
                        maxValue=j;
                    }
                }
                int temp=array[i];
                array[i]=array[maxValue];
                array[maxValue]=temp;
            }
            }
        }
        //double array
        public static void Sort(double[] array,int x)
        {
            if(x==-1){
            for(int i=0;i<array.Length-1;i++)
            {
                int maxValue=i;
                for(int j=i+1;j<array.Length;j++)
                {
                    if(array[j]>array[maxValue])
                    {
                        maxValue=j;
                    }
                }
                double temp=array[i];
                array[i]=array[maxValue];
                array[maxValue]=temp;
            }
            }
        }
        //char array
        public static void Sort(char[] array,int x)
        {
            if(x==-1){
            for(int i=0;i<array.Length-1;i++)
            {
                int maxValue=i;
                for(int j=i+1;j<array.Length;j++)
                {
                    if(array[j]<array[maxValue])
                    {
                        maxValue=j;
                    }
                }
                char temp=array[i];
                array[i]=array[maxValue];
                array[maxValue]=temp;
            }
            }
        }
        //string array
        public static void Sort(string[] array,int x)
        {
            if(x==-1){
            for(int i=0;i<array.Length-1;i++)
            {
                int maxValue=i;
                for(int j=i+1;j<array.Length;j++)
                {
                    if(array[j].CompareTo(array[maxValue])>0)
                    {
                        maxValue=j;
                    }
                }
                string temp=array[i];
                array[i]=array[maxValue];
                array[maxValue]=temp;
            }
            }
        }


    }
}