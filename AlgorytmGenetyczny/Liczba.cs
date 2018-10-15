using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmGenetyczny
{
    public class Liczba
    {
        public double poczatek { get; set; }
        public double koniec { get; set; }
        public int precyzja { get; set; }
        public double dlugosclancucha { get; set; }
        public double wartoscX { get; set; }
        public string lancuchBinarny = string.Empty;
        public List<string> WieleLancuchowBinarnych = new List<string>();


        public Liczba(double k, double l, int p)
        {
            this.poczatek = k;
            this.koniec = l;
            this.precyzja = p;
            Policz();
            

        }


        public void Policz()
        {

            double m;
            m = Math.Round(Math.Log(Math.Pow(10, precyzja) * (koniec - poczatek), 2));
  
            this.dlugosclancucha = m;
        }

        public string generujLancuchBinarny(double n)
        {
            string lancuch = string.Empty;
            var rng = new Random(Guid.NewGuid().GetHashCode());

            for (int i = 0; i < n; i++)
                lancuch += rng.Next(2);

            this.lancuchBinarny = lancuch;

            return lancuchBinarny;
        }

        public List<string> generujWieleLancuchowBinarnych(int ile, double n)
        {
            List<string> DuzoLancuchowBinarnych = new List<string>();
            for (int i = 0; i < ile; i++)
                DuzoLancuchowBinarnych.Add(generujLancuchBinarny(n));

            this.WieleLancuchowBinarnych = DuzoLancuchowBinarnych;

            return WieleLancuchowBinarnych;
        }

        public List<double> zamienNaWartoscDziesietna(string lancuch)
        {
            int licznik = 0;
            double wart = 0;
            List<double> WartosciX = new List<double>();

            for (int i = ((lancuch.Length)-1); i >= 0; i--)
            {
                if (lancuch[i] == 1)
                {
                    wart += Math.Pow(2, licznik);
                    licznik++;
                }

                else
                {
                    licznik++;
                }
                WartosciX[i] += wart;
            }
                
            return WartosciX;
        }


        public double przesuniecieDoPrzedzialu(double x)
        {

            x = poczatek + ((koniec - poczatek) * x / (Math.Pow(2, (dlugosclancucha - 1))));

            return x; //zamienic na tablice czy costam

        }


        public double algorytm(double x, double n)
        {
            double wynik;
            int A = 10;
            double w = 20 * Math.PI;
            wynik = A * dlugosclancucha;
            for (int i = 0; i <= n; i++)
            {

                wynik = Math.Pow(x, 2) - A * Math.Cos(w * x);

            }

            return wynik;
        }

    }
}
