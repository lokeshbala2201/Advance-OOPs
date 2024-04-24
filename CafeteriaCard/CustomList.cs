using System;
using System.Collections;


namespace CafeteriaCard
{
    public partial class CustomList<Type>
    {
        private int _count;
        private int _capacity;
        public int Count { get{return _count;}  }
        public int Capacity { get{return _capacity;} }
        private Type[] _array;
        public Type this[int index]
        {
            get{return _array[index];}
            set{_array[index]=value;}
        }

        public CustomList()
        {
            _count=0;
            _capacity=4;
            _array=new Type[_capacity];
        }
        public CustomList(int size)
        {
            _count=0;
            _capacity=size;
            _array=new Type[_capacity];
        }
        public void Add(Type element)
        {
            if(_count==_capacity)
            {
                GrowSize();
            }
            _array[_count]=element;
            _count++;
        }
        void GrowSize()
        {
            _capacity*=2;
            Type[] temp=new Type[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i]=_array[i];
            }
            _array=temp;
        }
        public void AddRange(CustomList<Type> elements)
        {
            _capacity=_count+elements.Count+4;
            Type[] temp=new Type[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i]=_array[i];
            }
            int k=0;
            for(int j=_count;j<_count+elements.Count;j++)
            {
                temp[j]=elements[k];
                k++;
            }
            _array=temp;
            _count=_count+elements.Count;
        }
        public bool Contains(Type element)
         {
            bool flag=false;
            foreach(Type i in _array)
            {
                if(element.Equals(i))
                {
                    flag = true;
                }
            }
            return flag;

            
         }
         public int IndexOf(Type element)
         {
            int index=-1;
            for(int i=0;i<_capacity;i++)
            {
                if(_array[i].Equals(element)){
                    index=i;
                    break;
                }
            }
            return index;
            
         }
        public void Insert(int position,Type element)
        {
            _capacity=_capacity+1;
            Type[] temp=new Type[_capacity];
            for(int i=0;i<_capacity;i++)
            {
                if(i<position){
                    temp[i]=_array[i];
                }
                else if(i==position)
                {
                    temp[i]=element;
                }else if(i>position)
                {
                    temp[i]=_array[i-1];
                }
            }
            _array=temp;
            _count++;

        }
        public void RemoveAt(int position)
        {
            _capacity=_capacity--;
      
            for(int i=0;i<_count-1;i++)
            {
                
                if(i>=position)
                {
                    _array[i]=_array[i+1];
                }
               
            }
            
            _count--;
        }
        public bool Remove(Type element)
        {
            int position=IndexOf(element);
            if(position>=0)
            {
                RemoveAt(position);
                return true;
            }
            return false;
        }
        public void Reverse()
        {
            Type[] temp=new Type[_count];
            int k=0;
            for(int i=_count-1;i>=0;i--)
            {
                temp[k]=_array[i];
                k++;
            }
            _array=temp;
        }
    }
}