using System;

namespace Laboratorium1_2
{
    abstract class Figura
    {
        private string nazwa;
        private char[] pozycja;
        private string kolor;

        public string Nazwa
        {
            get => nazwa;
            set => nazwa = value;
        }
        public char[] Pozycja
        {
            get => pozycja;
            set => pozycja = value;
        }
        public string Kolor
        {
            get => kolor;
            set
            {
                if (kolor == "biały" || kolor == "czarny")
                {
                    kolor = "czarny";
                }
            }
        }
        public Figura(string nazwa_pionka, char[] pozycja_pionka, string kolor_pionka)
        {
            nazwa = nazwa_pionka;
            pozycja = pozycja_pionka;
            kolor = kolor_pionka;
        }
        public virtual bool czyMoznaPrzesunac()
        {
            if (Kolor == "biały")
            {
                if (Pozycja[1] > 56)
                {
                    Console.WriteLine("Nie można przesunąć do przodu");
                    return false;
                }
                else if (Pozycja[1] < 49)
                {
                    Console.WriteLine("Nie można przesunąć confnąć");
                    return false;
                }
            }
            else if (Kolor == "czarny")
            {
                if (Pozycja[1] < 49)
                {
                    Console.WriteLine("Nie można przesunąć do przodu");
                    return false;
                }
                else if (Pozycja[1] > 56)
                {
                    Console.WriteLine("Nie można przesunąć confnąć");
                    return false;
                }
            }
            if (Convert.ToChar(Pozycja[0].ToString().ToUpper()) < 65)
            {
                Console.WriteLine("Nie można przesunąć");
                return false;
            }
            else if (Convert.ToChar(Pozycja[0].ToString().ToUpper()) > 71)
            {
                Console.WriteLine("Nie można przesunąć");
                return false;
            }

            return true;
        }

        public Action<char[]> showMesssage;

        public void Przesun(char[] NowaPozycja)
        {
            showMesssage = message;

            this.pozycja = NowaPozycja;
         
        }
        public void message(char[] n)
        {
            Console.WriteLine(this.Kolor + " " + this.Nazwa + " został przesuniety z pozycj [" + this.pozycja[0] + " " + this.pozycja[1] + "] na pozycje [");
        }
        public override string ToString()
        {
            return this.Kolor + " " + this.Nazwa + " jest na pozycjii [" + this.pozycja[0] + " " + this.pozycja[1] + "]";
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var indeksator = new Szachownica();
            Krol k = new Krol(new char[] { 'g', '1' }, "czarny");
            k.czyMoznaPrzesunac();
            k.showMesssage += k.message ;
            k.ToString();
            Dama d = new Dama(new char[] { 'g', '1' }, "biały");
            indeksator.Add(k);
            if (k.czyMoznaPrzesunac())
            {
                k.Przesun(new char[] { 'g', '2' });
                k.Przesun(new char[] { 'g', '3' });
                k.Przesun(new char[] { 'g', '5' });
            }
       
            GenericList<Figura> lista = new GenericList<Figura>();
     


            
        }
    }
 

}