using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    /// <summary>
    /// This class create the custom list <see cref="CustomList"/>
    /// </summary>
    /// <typeparam name="Type"></typeparam>
    public partial class CustomList<Type>
    {
        //fields
        //private
        private int _count;
        private int _capacity;
        private Type[] _array;
        //properties
        public int Count { get{return _count;}  } //readOnly
        public int Capacity { get{return _capacity;}}//read only
        
        public Type this[int index]
        {
            get{return _array[index];}
            set{_array[index]=value;}
        }

        //constructor without parameters
        public CustomList()
        {
            _count=0;
            _capacity=4;
            _array=new Type[_capacity];
        }
        //constructor with parameters
        public CustomList(int size)
        {
            _count=0;
            _capacity=size;
            _array=new Type[_capacity];

        }

        //Methods
        //add metohd
        public  void Add(Type element)
        {
            if(_count==_capacity)
            {
                GrowSize();
            }
            _array[_count]=element;
            _count++;
        }

        //grow size method
        public void GrowSize()
        {
            _capacity*=2;
            Type[] temp=new Type[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i]=_array[i];
            }
            _array=temp;
        }

        //Add range Method
        public void AddRange(CustomList<Type> elements)
        {
            _capacity=_capacity+elements.Count+4;
            Type[] temp=new Type[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i]=_array[i];
            }
            int k=0;
            for(int i=_count;i<_count+elements.Count;i++)
            {
                temp[i]=elements[k];
                k++;
            }
            _array=temp;
            _count=_count+elements.Count;
        }
    }
}