using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Laboratorium1_2
{
    class Szachownica : Ienumerable
    {
        private Figura[] arr = new Figura[64];
        int nextIndex = 0;
        public Figura this[int i] => arr[i];

        public void Add(Figura value)
        {
            if (nextIndex >= arr.Length)
                throw new IndexOutOfRangeException($"The collection can hold only {arr.Length} elements.");
            arr[nextIndex++] = value;
        }

        public void WriteAll()
        {
            IEnumerator e = arr.GetEnumerator();
            while (e.MoveNext()&&e.Current !=null)
            {
                Console.WriteLine(e.Current);

            }
        }

    }
      public class GenericList<T>
    {
        int position;
        T[] data = new T[64];
        public void Push(T obj) { data[position++] = obj; }
        public T Pop() { return data[--position]; }
        public void WriteAll()
        {
            IEnumerator e = data.GetEnumerator();
            
            while (e.MoveNext()&&e.Current !=null){
                Console.WriteLine(e.Current);
            }
            
        }
        
    }
}
