using System;
using System.Collections.Generic;
using AlgorytmGenetyczny;

namespace Algorytm_genetyczny
{
    class Program
    {        
        static void Main(string[] args)
        {
            // pierwszy osobnik

            Console.WriteLine("______________*______________*______________*______________*______________*______________*______________");
            Console.WriteLine();

            Osobnik Jeden = new Osobnik(-1, 1, 3);

            Jeden.Policz();
            Console.WriteLine("Dlugosc lancucha binarnego Pierwszego osobnika to: {0} ", Jeden.dlugosclancucha);


            Console.WriteLine("Podaj ilosc lancuchow binarnych Pierwszego osobnika: ");
            Jeden.ilosclancuchow = int.Parse(Console.ReadLine());


            Console.WriteLine();
            Console.WriteLine();

            List<double> WieleLancuchowJeden = new List<double>();

            for (int i = 1; i <= Jeden.ilosclancuchow; i++)
            {
                Jeden.generujLancuchBinarny(Jeden.dlugosclancucha);
                Console.WriteLine("Lancuch binarny nr {0} dla Pierwszego osobnika to: {1}", i, Jeden.lancuchBinarny);

                Jeden.zamienNaWartoscDziesietna(Jeden.lancuchBinarny);
                WieleLancuchowJeden.Add(Jeden.wartoscX);
                Console.WriteLine("Wartosc dziesietna lancucha binarnego nr {0} dla Pierwszego osobnika to: {1}", i, WieleLancuchowJeden[i - 1]);
                Console.WriteLine();
            }

            Jeden.WieleLancuchow = WieleLancuchowJeden;

            List<double> WielePunktowJeden = new List<double>();
            for (int i = 1; i <= Jeden.ilosclancuchow; i++)
            {
                Jeden.przesuniecieDoPrzedzialu(Jeden.WieleLancuchow[i-1], Jeden.dlugosclancucha);
                WielePunktowJeden.Add(Jeden.punkt);
                Jeden.punkt = 0;
                Console.WriteLine("Wartosc punktu dla lancucha binarnego nr {0} Pierwszego osobnika to: {1}", i, WielePunktowJeden[i - 1]);
                Console.WriteLine();
            }


            Jeden.WielePunktowX = WielePunktowJeden;


            Jeden.algorytm(Jeden.WielePunktowX, Jeden.ilosclancuchow);
            Console.WriteLine("Wartosc funkcji dla podanych lancuchow binarnych Pierwszego osobnika to: {0}", Jeden.wynikAlgorytmu);



            // drugi osobnik

            Console.WriteLine("______________*______________*______________*______________*______________*______________*______________");
            Console.WriteLine();

            Osobnik Dwa = new Osobnik(-1, 1, 3);

            Dwa.Policz();
            Console.WriteLine("Dlugosc lancucha binarnego Drugiego oosobnika to: {0} ", Dwa.dlugosclancucha);


            Console.WriteLine("Podaj ilosc lancuchow binarnych dla Drugiego osobnika: ");
            Dwa.ilosclancuchow = int.Parse(Console.ReadLine());

            List<double> WieleLancuchowDwa = new List<double>();

            for (int i = 1; i <= Dwa.ilosclancuchow; i++)
            {
                Dwa.generujLancuchBinarny(Dwa.dlugosclancucha);
                Console.WriteLine("Lancuch binarny nr {0} dla Drugiego oosobnika to: {1}", i, Dwa.lancuchBinarny);

                Dwa.zamienNaWartoscDziesietna(Dwa.lancuchBinarny);
                WieleLancuchowDwa.Add(Dwa.wartoscX);
                Console.WriteLine("Wartosc dziesietna lancucha binarnego nr {0} dla Drugiego osobnika to: {1}", i, WieleLancuchowDwa[i - 1]);
                Console.WriteLine();
            }

            Dwa.WieleLancuchow = WieleLancuchowDwa;

            List<double> WielePunktowDwa = new List<double>();
            for (int i = 1; i <= Dwa.ilosclancuchow; i++)
            {
                Dwa.przesuniecieDoPrzedzialu(Dwa.WieleLancuchow[i - 1], Dwa.dlugosclancucha);
                WielePunktowDwa.Add(Dwa.punkt);
                Dwa.punkt = 0;
                Console.WriteLine("Wartosc punktu dla lancucha binarnego nr {0} Drugiego osobnika to: {1}", i, WielePunktowDwa[i - 1]);
                Console.WriteLine();
            }

            Dwa.WielePunktowX = WielePunktowDwa;


            Dwa.algorytm(Dwa.WielePunktowX, Dwa.ilosclancuchow);
            Console.WriteLine("Wartosc funkcji dla podanych lancuchow binarnych Drugiego osobnika to: {0}", Dwa.wynikAlgorytmu);


            // trzeci osobnik

            Console.WriteLine("______________*______________*______________*______________*______________*______________*______________");
            Console.WriteLine();

            Osobnik Trzy = new Osobnik(-1, 1, 3);

            Trzy.Policz();
            Console.WriteLine("Dlugosc lancucha binarnego Trzeciego osobnika to: {0} ", Trzy.dlugosclancucha);


            Console.WriteLine("Podaj ilosc lancuchow binarnych: ");
            Trzy.ilosclancuchow = int.Parse(Console.ReadLine());

            List<double> WieleLancuchowTrzy = new List<double>();

            for (int i = 1; i <= Trzy.ilosclancuchow; i++)
            {
                Trzy.generujLancuchBinarny(Trzy.dlugosclancucha);
                Console.WriteLine("Lancuch binarny nr {0} dla Trzeciego osobnika to: {1}", i, Trzy.lancuchBinarny);

                Trzy.zamienNaWartoscDziesietna(Trzy.lancuchBinarny);
                WieleLancuchowTrzy.Add(Trzy.wartoscX);
                Console.WriteLine("Wartosc dziesietna lancucha binarnego nr {0} dla Trzeciego osobnika to: {1}", i, WieleLancuchowTrzy[i - 1]);
                Console.WriteLine();
            }

            Trzy.WieleLancuchow = WieleLancuchowTrzy;

            List<double> WielePunktowTrzy = new List<double>();
            for (int i = 1; i <= Trzy.ilosclancuchow; i++)
            {
                Trzy.przesuniecieDoPrzedzialu(Trzy.WieleLancuchow[i - 1], Trzy.dlugosclancucha);
                WielePunktowTrzy.Add(Trzy.punkt);
                Trzy.punkt = 0;
                Console.WriteLine("Wartosc punktu dla lancucha binarnego nr {0} Trzeciego osobnika to: {1}", i, WielePunktowTrzy[i - 1]);
                Console.WriteLine();
            }

            Trzy.WielePunktowX = WielePunktowTrzy;


            Trzy.algorytm(Trzy.WielePunktowX, Trzy.ilosclancuchow);
            Console.WriteLine("Wartosc funkcji dla podanych lancuchow binarnych Trzeciego osobnika to: {0}", Trzy.wynikAlgorytmu);

            Console.WriteLine("______________*______________*______________*______________*______________*______________*______________");
            Console.WriteLine();

            Populacja populacjaPierwsza = new Populacja();
            populacjaPierwsza.OsobnikiZPopulacji.Add(Jeden.wynikAlgorytmu);

            populacjaPierwsza.OsobnikiZPopulacji.Add(Dwa.wynikAlgorytmu);

            populacjaPierwsza.OsobnikiZPopulacji.Add(Trzy.wynikAlgorytmu);

            int iloscOsobnikow = 3;

            for(int i = 0; i < iloscOsobnikow; i++)
            {
                Console.WriteLine("Osobnik {0} ma wartosc funkcji wynoszaca {1}.", i+1, populacjaPierwsza.OsobnikiZPopulacji[i]);
                Console.WriteLine();

            }

            Console.ReadKey();


        }
    }
}
;