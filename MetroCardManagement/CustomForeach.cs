using System;
using System.Collections;
using System.Dynamic;

namespace MetroCardManagement
{
    /// <summary>
    /// This class allow the customlist to iterable in foreach loop<see cref="CustomList"/> 
   /// </summary>

    public partial class CustomList<Type>:IEnumerator,IEnumerable
    {
        int position;
        public IEnumerator GetEnumerator()
        {
            position=-1;
            return (IEnumerator)this;   
        }
        public bool MoveNext()
        {
            if(position<Count-1)
            {
                position++;
                return true;
            }
            Reset();
            return false;
        }
        public void Reset()
        {
            position=-1;
        }
        public object Current{get{return _array[position];}}
        
    }
}