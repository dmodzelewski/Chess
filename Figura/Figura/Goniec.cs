using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura
{
    public class Goniec : Figura
    {
        public Goniec(string nazwa_pionka, char[] pozycja_pionka, string kolor_pionka) : base(nazwa_pionka, pozycja_pionka, kolor_pionka) { }

        public void czyMoznaPrzesunac()
        {
            base.czyMoznaPrzesunac();

        }
    }
}
