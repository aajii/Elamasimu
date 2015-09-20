using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elamasimu
{
    /// <summary>
    /// Peliluokka.
    /// </summary>
    public class Peli
    {
        public List<Paikka> paikat;

        public Peli()
        {
            paikat = new List<Paikka>();
        }

        public void AloitaPeli(int tavoiteOnnellisuus, int maxPaivat)
        {
            Pelaaja pelaaja = new Pelaaja(PyydaNimiSyote("Pelaajan nimi?"));
            while (pelaaja.ominaisuudet["Onnellisuus"] < tavoiteOnnellisuus)
            {
                Paiva paiva = new Paiva();
                while (paiva.tuntejaJaljella > 0)
                {
                    TulostaPelaajanOminaisuudet(pelaaja);
                    Console.WriteLine("Minne haluat mennä?");
                    TulostaPaikat(paikat);
                    Paikka paikka = ValitsePaikka(paikat);
                    TulostaAktiviteetit(paikka);
                    Aktiviteetti aktiviteetti = ValitseAktiviteetti(paikka);
                }
            }
            Console.WriteLine("Onneksi olkoon, olet täydellisen onnellinen!");
        }

        private void TulostaAktiviteetit(Paikka paikka)
        {
            foreach (var aktiviteetti in paikka.aktiviteetit)
            {

            }
        }

        private Aktiviteetti ValitseAktiviteetti(Paikka valittuPaikka)
        {
            Console.WriteLine("Poistu [ESC]");
            Console.Write("> ");
            return null;
        }

        private Paikka ValitsePaikka(List<Paikka> paikat)
        {
            throw new NotImplementedException();
        }

        private void TulostaPaikat(List<Paikka> paikat)
        {
            foreach (var paikka in paikat)
            {
                Console.WriteLine(paikka.nimi + " [" + paikka.lyhytvalinta + "]");
            }
        }

        private string PyydaNimiSyote(String tuloste)
        {
            Console.Write(tuloste + " >");
            String nimi = Console.ReadLine();
            return nimi;
        }

        public void TulostaPelaajanOminaisuudet(Pelaaja pelaaja)
        {
            String tuloste = "Pelaaja: " + pelaaja.nimi + " Raha: " + pelaaja.ominaisuudet["Raha"];
            Console.WriteLine(tuloste);
        }
    }
}
