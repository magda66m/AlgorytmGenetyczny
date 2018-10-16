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
        public double punkt { get; set; }
        public double wynikAlgorytmu { get; set; }
        public List<double> WielePunktowX { get; set; }
        public List<double> WieleLancuchow { get; set; }
        public double ilosclancuchow { get; set; }


        public Liczba(double a, double b, int d)
        {
            this.poczatek = a;
            this.koniec = b;
            this.precyzja = d;
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

        public double zamienNaWartoscDziesietna(string lancuch)
        {
            int licznik = 0;
            double wart = 0;

            for (int i = ((lancuch.Length)-1); i >= 0; i--)
            {
                if (lancuch[i] == '1')
                {
                    wart += Math.Pow(2, licznik);
                    licznik++;
                }

                else
                {
                    licznik++;
                }
      
            }

            this.wartoscX = wart;
            return wartoscX;
        }


        public double przesuniecieDoPrzedzialu(double x, double n)
        {
            double dlugoscprzedzialu = koniec - poczatek;
            double pierwszazmienna = dlugoscprzedzialu * x;
            double potega = Math.Pow(2, n);
            double drugazmienna = potega - 1;
            this.punkt = poczatek + (pierwszazmienna/ drugazmienna);

            return punkt;
        }


        public double algorytm(List<double> ListaX, double iloscLancuchow)
        {
            int A = 10;
            double wynik = 0;
            double w = 20 * Math.PI;


            for (int i = 0; i < ListaX.Count; i++)
            {
                
                wynik += (Math.Pow(ListaX[i], 2)) - (A * (Math.Cos(w * ListaX[i])));

            }

            wynik += A * iloscLancuchow;
            this.wynikAlgorytmu = wynik;
            return wynikAlgorytmu;
        }
    }
}
