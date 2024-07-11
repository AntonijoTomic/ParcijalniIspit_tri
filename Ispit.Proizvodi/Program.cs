
using Ispit.Proizvodi.Klase;
using System;
using System.Collections.Generic;

namespace Ispit.Proizvodi
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Predavac predavac = new Predavac()
            {
                Id = 1,
                Ime = "Karlo",
                Prezime = "Markovic"
            };        

            List<Polaznik> polaznici = new List<Polaznik>
            {
              new Polaznik  { Id = 1, Ime = "Antonijo", Prezime = "Tomic" },
              new Polaznik { Id = 2, Ime = "Vlatka", Prezime = "Maric" },
              new Polaznik { Id = 3, Ime = "Drago", Prezime = "Hodak" },
              new Polaznik { Id = 4, Ime = "Ratko", Prezime = "Cosic" }
            };

            predavac.Ispit += delegate(DateTime vrijemePocetka)
            {
                foreach (Polaznik p in polaznici)
                {
                    p.OdgovoriNaPitanja(vrijemePocetka);
                    p.IspitZavrsen += predavac.IspitZaprimljen;
                }
            };

            predavac.ZvoniZvono();

            
            polaznici[0].PredajOdgovoreNaPitanja();

            Console.ReadKey();
        }
    }
}

