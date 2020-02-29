using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorium1_2
{
    class Wieza : Figura
    {

        public Wieza(char[] pozycja_pionka, string kolor_pionka, string nazwa_pionka = "Wieza") : base(nazwa_pionka, pozycja_pionka, kolor_pionka) { }
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
