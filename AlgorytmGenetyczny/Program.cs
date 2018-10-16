using System;
using System.Collections.Generic;
using AlgorytmGenetyczny;

namespace Algorytm_genetyczny
{
    class Program
    {        
        static void Main(string[] args)
        {

            Liczba Jeden = new Liczba(-1, 1, 3);

            Jeden.Policz();
            Console.WriteLine("Dlugosc lancucha binarnego to: {0} ", Jeden.dlugosclancucha);


            Console.WriteLine("Podaj ilosc lancuchow binarnych: ");
            Jeden.ilosclancuchow = int.Parse(Console.ReadLine());


            Console.WriteLine();
            Console.WriteLine();

            List<double> WieleLancuchow = new List<double>();

            for (int i = 1; i <= Jeden.ilosclancuchow; i++)
            {
                Jeden.generujLancuchBinarny(Jeden.dlugosclancucha);
                Console.WriteLine("Lancuch binarny nr {0} to: {1}", i, Jeden.lancuchBinarny);

                Jeden.zamienNaWartoscDziesietna(Jeden.lancuchBinarny);
                WieleLancuchow.Add(Jeden.wartoscX);
                Console.WriteLine("Wartosc dziesietna lancucha binarnego nr {0} to: {1}", i, WieleLancuchow[i - 1]);
                Console.WriteLine();
            }

            Jeden.WieleLancuchow = WieleLancuchow;

            Console.WriteLine();
            Console.WriteLine();

            List<double> WielePunktow = new List<double>();
            for (int i = 1; i <= Jeden.ilosclancuchow; i++)
            {
                Jeden.przesuniecieDoPrzedzialu(Jeden.WieleLancuchow[i-1], Jeden.dlugosclancucha);
                WielePunktow.Add(Jeden.punkt);
                Jeden.punkt = 0;
                Console.WriteLine("Wartosc punktu dla lancucha binarnego nr {0} to: {1}", i, WielePunktow[i - 1]);
                Console.WriteLine();
            }


            Console.WriteLine();
            Console.WriteLine();


            Jeden.WielePunktowX = WielePunktow;


            Jeden.algorytm(Jeden.WielePunktowX, Jeden.ilosclancuchow);
            Console.WriteLine("Wartosc funkcji dla podanych lancuchow binarnych to: {0}", Jeden.wynikAlgorytmu);


            Console.WriteLine();
            Console.WriteLine();

            Console.ReadKey();


        }
    }
}
;