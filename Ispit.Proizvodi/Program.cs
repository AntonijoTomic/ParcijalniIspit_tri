using Ispit.Proizvodi.Klase;
using System;
using System.Collections.Generic;

namespace Ispit.Proizvodi
{
    public delegate void PocniPisatiIspit(DateTime vrijemePocetka);
    internal class Program
    {
        static void Main(string[] args)
        {
            Predavac predavac = new Predavac()
            {
                Id=1,
                Ime="Karlo",
                Prezime="Markovic"
            };

            predavac.ZvoniZvono();

            List<Polaznik> polaznici = new List<Polaznik>
            {
              new Polaznik  { Id = 1, Ime = "Antonijo", Prezime = "Tomic" },
              new Polaznik { Id = 2, Ime = "Vlatka", Prezime = "Maric" },
              new Polaznik { Id = 3, Ime = "Drago", Prezime = "Hodak" },
              new Polaznik { Id = 4, Ime = "Ratko", Prezime = "Cosic" }
            };

            foreach(Polaznik p in polaznici)
            {
                p.OdgovoriNaPitanja(DateTime.Now);
            }

            polaznici[0].PredajOdgovoreNaPitanja();

            predavac.IspitZaprimljen(polaznici[0]);


            Console.ReadKey();
        }
    }
}

//