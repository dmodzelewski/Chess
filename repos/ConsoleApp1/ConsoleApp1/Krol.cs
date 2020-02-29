using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorium1_2
{
    class Krol : Figura
    {
        public Krol(char[] pozycja_pionka, string kolor_pionka, string nazwa_pionka = "Król") : base(nazwa_pionka, pozycja_pionka, kolor_pionka) { }
        public override bool czyMoznaPrzesunac()
        {
            return base.czyMoznaPrzesunac();
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
