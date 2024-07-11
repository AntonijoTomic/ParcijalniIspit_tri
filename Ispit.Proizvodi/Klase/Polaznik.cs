using System;

namespace Ispit.Proizvodi.Klase
{
    public class Polaznik
    {
        public delegate void PredajIspit(Polaznik polaznik);
        public event PredajIspit IspitZavrsen;
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public string ImePrezime
        {
            get { return $"{Ime} {Prezime}"; }
        }

        public void OdgovoriNaPitanja(DateTime vrijeme_pocetka)
        {
            Console.WriteLine($"{ImePrezime},  {vrijeme_pocetka}- Pocnite odgovarati na pitanja!");
            Console.WriteLine("============================================================");
        }

        public void PredajOdgovoreNaPitanja()
        {
            Console.WriteLine($"{ImePrezime} - Odgovor zaprimljen");
            IspitZavrsen?.Invoke(this);
        }




    }
}
