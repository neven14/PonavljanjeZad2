using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PonavljanjeZad2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Broj;
            KlasaD MainObjekt = new KlasaD();
            bool Uvjet = MainObjekt.Suprotno(true);
            Broj = MainObjekt.Suprotno(50);
            Console.WriteLine("Suprotno od true je =  " + Uvjet);
            Console.WriteLine("Suprotno od 50 je =  " + Broj);
            Console.ReadKey();
        }
    }
}
