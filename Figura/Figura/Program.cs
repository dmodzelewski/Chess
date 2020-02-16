using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura
{
    public abstract class Figura
    {
        private string nazwa;
        private char[] pozycja;
        private string kolor;

        public string Nazwa
        {
            get { return nazwa; }
            set { nazwa = value; }
        }
        public char[] Pozycja
        {
            get { return pozycja; }
            set { pozycja = value; }
        }
        public string Kolor
        {
            get { return kolor; }
            set { kolor = value; }
        }

      
        public Figura(string nazwa_pionka, char[] pozycja_pionka,string kolor_pionka)
        {
            nazwa = nazwa_pionka;
            pozycja = pozycja_pionka;
            kolor = kolor_pionka;
        }
        public abstract bool czyMoznaPrzesunac();

        public abstract void wyswietl(Object obj);
       
    }

    public class Krol : Figura
    {
       public Krol(string nazwa_pionka, char[] pozycja_pionka,string kolor_pionka):base(nazwa_pionka,pozycja_pionka,kolor_pionka) 
        {
           
        }
       
        public override bool czyMoznaPrzesunac()
        {
            if(Kolor == "biały")
            {
                if (Pozycja[1] >= 56)
                {
                    Console.WriteLine("Nie można przesunąć do przodu");
                    return false;
                }
                else if(Pozycja[1] <= 49)
                {
                    Console.WriteLine("Nie można przesunąć confnąć");
                    return false;
                }
            }
            else if (true)
            {
                if (Pozycja[1] <= 49)
                {
                    Console.WriteLine("Nie można przesunąć do przodu");
                    return false;
                }
                else if (Pozycja[1] >= 56)
                {
                    Console.WriteLine("Nie można przesunąć confnąć");
                    return false;
                }
            }
            if(Pozycja[0] <= 65)
            {
                Console.WriteLine("Nie można przesunąć");
                return false;
            }
            else if(Pozycja[0] >= 71)
            {
                Console.WriteLine("Nie można przesunąć");
                return false;
            }

            return true;

        }

        public override void wyswietl(Object obj)
        {          
            Console.WriteLine(obj.ToString());
           
        }

    }
    public class Dama : Figura
    {
        public Dama(string nazwa_pionka, char[] pozycja_pionka, string kolor_pionka) : base(nazwa_pionka, pozycja_pionka, kolor_pionka)
        { }

        public override bool czyMoznaPrzesunac()
        {
            if (Kolor == "biały")
            {
                if (Pozycja[1] >= 8)
                {
                    Console.WriteLine("Nie można przesunąć do przodu");
                    return false;
                }
                else if (Pozycja[1] <= 1)
                {
                    Console.WriteLine("Nie można przesunąć confnąć");
                    return false;
                }
            }
            else if (true)
            {
                if (Pozycja[1] <= 1)
                {
                    Console.WriteLine("Nie można przesunąć do przodu");
                    return false;
                }
                else if (Pozycja[1] >= 8)
                {
                    Console.WriteLine("Nie można przesunąć confnąć");
                    return false;
                }
            }
            if (Pozycja[0] <= 65)
            {
                Console.WriteLine("Nie można przesunąć");
                return false;
            }
            else if (Pozycja[0] >= 71)
            {
                Console.WriteLine("Nie można przesunąć");
                return false;
            }

            return true;

        }


        public override void wyswietl(Object obj)
        {
            Console.WriteLine(obj.ToString());
          
        }

    }
    public class Goniec : Figura
    {
        public Goniec(string nazwa_pionka, char[] pozycja_pionka, string kolor_pionka) : base(nazwa_pionka, pozycja_pionka, kolor_pionka) { }

        public override bool czyMoznaPrzesunac()
        {
            if (Kolor == "biały")
            {
                if (Pozycja[1] >= 56)
                {
                    Console.WriteLine("Nie można przesunąć do przodu");
                    return false;
                }
                else if (Pozycja[1] <= 49)
                {
                    Console.WriteLine("Nie można przesunąć confnąć");
                    return false;
                }
            }
            else if (true)
            {
                if (Pozycja[1] <= 49)
                {
                    Console.WriteLine("Nie można przesunąć do przodu");
                    return false;
                }
                else if (Pozycja[1] >= 56)
                {
                    Console.WriteLine("Nie można przesunąć confnąć");
                    return false;
                }
            }
            if (Pozycja[0] <= 65)
            {
                Console.WriteLine("Nie można przesunąć");
                return false;
            }
            else if (Pozycja[0] >= 71)
            {
                Console.WriteLine("Nie można przesunąć");
                return false;
            }

            return true;

        }


        public override void wyswietl(Object obj)
        {
            Console.WriteLine(obj.ToString());
           
        }
    }
    public class Wieza : Figura {
        public Wieza(string nazwa_pionka, char[] pozycja_pionka, string kolor_pionka) : base(nazwa_pionka, pozycja_pionka, kolor_pionka) { }

        public override bool czyMoznaPrzesunac()
        {
            if (Kolor == "biały")
            {
                if (Pozycja[1] >= 56)
                {
                    Console.WriteLine("Nie można przesunąć do przodu");
                    return false;
                }
                else if (Pozycja[1] <= 49)
                {
                    Console.WriteLine("Nie można przesunąć confnąć");
                    return false;
                }
            }
            else if (true)
            {
                if (Pozycja[1] <= 49)
                {
                    Console.WriteLine("Nie można przesunąć do przodu");
                    return false;
                }
                else if (Pozycja[1] >= 56)
                {
                    Console.WriteLine("Nie można przesunąć confnąć");
                    return false;
                }
            }
            if (Pozycja[0] <= 65)
            {
                Console.WriteLine("Nie można przesunąć");
                return false;
            }
            else if (Pozycja[0] >= 71)
            {
                Console.WriteLine("Nie można przesunąć");
                return false;
            }

            return true;

        }


        public override void wyswietl(Object obj)
        {
            Console.WriteLine(obj.ToString());
      
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Krol k = new Krol("król", new char[] { 'g', '1' }, "biały");
            k.wyswietl(k);
            k.czyMoznaPrzesunac();
        }
    }
}
