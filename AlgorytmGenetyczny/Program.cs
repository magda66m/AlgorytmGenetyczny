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

            Liczba Jeden = new Liczba(-1, 1, 6);

            Jeden.Policz();
            Console.WriteLine("Dlugosc lancucha binarnego to: {0} ", Jeden.dlugosclancucha);

            Jeden.generujLancuchBinarny(Jeden.dlugosclancucha);
            Console.WriteLine(Jeden.lancuchBinarny);

            Jeden.zamienNaWartoscDziesietna(Jeden.lancuchBinarny);

            //Jeden.generujWieleLancuchowBinarnych(4, Jeden.dlugosclancucha);
            //Console.WriteLine(Jeden.WieleLancuchowBinarnych);

            //Jeden.wartoscDziesietna(Jeden.generujWieleLancuchowBinarnych(4, Jeden.generujLancuchBinarny(Jeden.dlugosclancucha)));
            //Jeden.przesuniecieDoPrzedzialu(Jeden.wartoscDziesietna(Jeden.WieleLancuchowBinarnych));


            Console.ReadKey();


        }
    }
}
