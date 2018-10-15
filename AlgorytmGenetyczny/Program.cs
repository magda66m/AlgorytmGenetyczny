using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorytmGenetyczny;



namespace Algorytm_genetyczny
{
    class Program
    {
        



        static void Main(string[] args)
        {

            Liczba Jeden = new Liczba(-1, 1, 5);

            Jeden.Policz();
            Console.WriteLine("Dlugosc lancucha binarnego to: {0} ", Jeden.dlugosclancucha);

            int ilosclancuchow;
            Console.WriteLine("Podaj ilosc lancuchow binarnych: ");
            ilosclancuchow = int.Parse(Console.ReadLine());


            Console.WriteLine();
            Console.WriteLine();


            List<double> WieleLancuchow = new List<double>();

            for (int i = 1; i <= ilosclancuchow; i++)
            {
                Jeden.generujLancuchBinarny(Jeden.dlugosclancucha);
                Console.WriteLine("Lancuch binarny nr {0} to: {1}", i, Jeden.lancuchBinarny);

                Jeden.zamienNaWartoscDziesietna(Jeden.lancuchBinarny);
                WieleLancuchow.Add(Jeden.wartoscX);
                Console.WriteLine("Wartosc dziesietna lancucha binarnego nr {0} to: {1}", i, WieleLancuchow[i - 1]);
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            List<double> WielePunktow = new List<double>();
            for (int i = 1; i <= ilosclancuchow; i++)
            {
                Jeden.przesuniecieDoPrzedzialu(WieleLancuchow[i-1], Jeden.dlugosclancucha);
                WielePunktow.Add(Jeden.punkt);
                Console.WriteLine("Wartosc punktu dla lancucha binarnego nr {0} to: {1}", i, WielePunktow[i - 1]);
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            List<double> WieleWynikow = new List<double>();
            for (int i = 1; i <= ilosclancuchow; i++)
            {
                Jeden.algorytm(WieleLancuchow[i - 1], Jeden.dlugosclancucha);
                WieleWynikow.Add(Jeden.wynikAlgorytmu);
                Console.WriteLine("Wartosc funkcji dla punktu {0} powstalego z lancucha binarnego nr {1} to: {2}", WielePunktow[i - 1], i, WieleWynikow[i - 1]);
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.ReadKey();


        }
    }
}
;