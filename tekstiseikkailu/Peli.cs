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
        public Paikat paikat;

        public Peli()
        {
            paikat = new Paikat();
        }

        public void AloitaPeli(int tavoiteOnnellisuus, int maxPaivat)
        {
            Pelaaja pelaaja = new Pelaaja(PyydaNimiSyote("Pelaajan nimi?"));
            while (pelaaja.Onnellisuus < tavoiteOnnellisuus)
            {
                Paiva paiva = new Paiva();
                while (paiva.tuntejaJaljella > 0)
                {
                    TulostaPelaajanOminaisuudet(pelaaja);
                    Console.WriteLine("Minne haluat mennä?");
                    TulostaPaikat(paikat);

                    while (paiva.tuntejaJaljella > 0)
                    {
                        Paikka paikka = ValitsePaikka(paikat);
                        TulostaAktiviteetit(paikka);
                        ConsoleKeyInfo ckiAkt = Console.ReadKey();
                        if (ckiAkt.Key == ConsoleKey.Escape) break; // TODO: Tähän joku nätimpi poistuminen
                        Aktiviteetti aktiviteetti = paikka.lyhytValinnatJaAktiviteetit[ckiAkt.KeyChar];
                        ToteutaAktiviteetti(pelaaja, aktiviteetti);
                    }
                }
                Console.WriteLine("Onneksi olkoon, olet täydellisen onnellinen!");
            }
        }

        private void ToteutaAktiviteetti(Pelaaja pelaaja, Aktiviteetti aktiviteetti)
        {
            

            throw new NotImplementedException();
        }

        private void TulostaAktiviteetit(Paikka paikka)
        {
            Console.WriteLine("Olet paikassa: " + paikka.nimi);
            Console.WriteLine("Valitse seuraavista: ");

            foreach (var aktiviteetti in paikka.lyhytValinnatJaAktiviteetit)
            {
                Console.WriteLine(aktiviteetti.Value.kuvaus + " [" + aktiviteetti.Key + "]");
            }
        }

        /// <summary>
        /// Tulosta kehote ja valitse paikka
        /// </summary>
        /// <param name="paikat"></param>
        /// <returns>Paikka</returns>
        private Paikka ValitsePaikka(Paikat paikat)
        {
            while (true)
            {
                Console.Write("> ");
                ConsoleKeyInfo ckiPaikka = Console.ReadKey();
                if (!paikat.lyhytvalinnatJaPaikat.ContainsKey(ckiPaikka.KeyChar)) continue;
                return paikat.lyhytvalinnatJaPaikat[ckiPaikka.KeyChar];
            }
        }

        private void TulostaPaikat(Paikat paikat)
        {
            foreach (var paikka in paikat.lyhytvalinnatJaPaikat)
            {
                Console.WriteLine(paikka.Value + " [" + paikka.Key + "]");
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
            String tuloste = "Pelaaja: " + pelaaja.nimi + " Raha: " + pelaaja.ominaisuudet.Raha;
            Console.WriteLine(tuloste);
        }
    }
}
