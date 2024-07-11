using System;

namespace Ispit.Proizvodi.Klase
{
    public delegate void PocniPisatiIspit(DateTime vrijemePocetka);
    public class Predavac
    {
        public event PocniPisatiIspit Ispit;
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public string ImePrezime
        {
            get { return $"{Ime} {Prezime}"; }
        }

        public void ZvoniZvono()
        {
            Console.WriteLine("Brrrrrrrrrrrrrrrrrrrrrrrrrrrrrr, ispit počinje.\n\n");
            if(Ispit != null)
            {
                Ispit(DateTime.Now);
            }
      
        }

        public void IspitZaprimljen(Polaznik polaznik)
        {
            Console.WriteLine("Zaprimljen ispit od polaznika: {0}", polaznik.ImePrezime);
        }
    }
}
