using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura
{
    class Szachownica
    {

        private Figura[] arr = new Figura[64];
        int nextIndex = 0;
        public Figura this[int i]=> arr[i];

        public void Add(Figura value)
        {
            if (nextIndex >= arr.Length)
                throw new IndexOutOfRangeException($"The collection can hold only {arr.Length} elements.");
            arr[nextIndex++] = value;
        }
    }
     
    }