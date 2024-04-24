using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BubbleSort
{
    public static class BubbleSort
    {
       //ascending
       //int array
        public static void  Sort(int[] intArray)
        {
            for(int i=0;i<intArray.Length;i++)
            {
                int temp=0;
                for(int j=0;j<intArray.Length-1;j++)
                {
                    if(intArray[j]>intArray[j+1])
                    {
                        temp=intArray[j];
                        intArray[j]=intArray[j+1];
                        intArray[j+1]=temp;
                    }
                }
            }
        }
        //char array
        public static void  Sort(char[] Array)
        {
            for(int i=0;i<Array.Length;i++)
            {
                char temp='a';
                for(int j=0;j<Array.Length-1;j++)
                {
                    if(Array[j]>Array[j+1])
                    {
                        temp=Array[j];
                        Array[j]=Array[j+1];
                        Array[j+1]=temp;
                    }
                }
            }
        }
        //double array
        public static void  Sort(double[] Array)
        {
            for(int i=0;i<Array.Length;i++)
            {
                double temp=0.0;
                for(int j=0;j<Array.Length-1;j++)
                {
                    if(Array[j]>Array[j+1])
                    {
                        temp=Array[j];
                        Array[j]=Array[j+1];
                        Array[j+1]=temp;
                    }
                }
            }
        }
        //string array
        public static void  Sort(string[] Array)
        {
            for(int i=0;i<Array.Length;i++)
            {
                string  temp="";
                for(int j=0;j<Array.Length-1;j++)
                {
                    if(Array[j].CompareTo(Array[j+1])>0)
                    {
                        temp=Array[j];
                        Array[j]=Array[j+1];
                        Array[j+1]=temp;
                    }
                }
            }
            
        }

        //ascending
        //int arrray
        public static void  Sort(int[] intArray,int x)
        {
            if(x==-1){
            for(int i=0;i<intArray.Length;i++)
            {
                int temp=0;
                for(int j=0;j<intArray.Length-1;j++)
                {
                    if(intArray[j]<intArray[j+1])
                    {
                        temp=intArray[j];
                        intArray[j]=intArray[j+1];
                        intArray[j+1]=temp;
                    }
                }
            }
            }
        }
        //double array
        public static void  Sort(double[] Array,int x)
        {
            if(x==-1){
            for(int i=0;i<Array.Length;i++)
            {
                double temp;
                for(int j=0;j<Array.Length-1;j++)
                {
                    if(Array[j]<Array[j+1])
                    {
                        temp=Array[j];
                        Array[j]=Array[j+1];
                        Array[j+1]=temp;
                    }
                }
            }
            }
        }
        //char array
        public static void  Sort(char[] Array,int x)
        {
            if(x==-1){
            for(int i=0;i<Array.Length;i++)
            {
                char temp='a';
                for(int j=0;j<Array.Length-1;j++)
                {
                    if(Array[j]<Array[j+1])
                    {
                        temp=Array[j];
                        Array[j]=Array[j+1];
                        Array[j+1]=temp;
                    }
                }
            }
            }
        }
        //string array
        public static void  Sort(string[] Array,int x)
        {
            if(x==-1){
            for(int i=0;i<Array.Length;i++)
            {
                string temp;
                for(int j=0;j<Array.Length-1;j++)
                {
                    if(Array[j].CompareTo(Array[j+1])<0)
                    {
                        temp=Array[j];
                        Array[j]=Array[j+1];
                        Array[j+1]=temp;
                    }
                }
            }
            }
        }
    }
}