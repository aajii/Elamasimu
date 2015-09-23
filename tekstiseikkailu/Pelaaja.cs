using System;
using System.Collections.Generic;

namespace Elamasimu
{
    /// <summary>
    /// Pelaaja
    /// </summary>
    public class Pelaaja
    {
        public string nimi;
        public int onnellisuus;
        internal Ominaisuudet ominaisuudet;
        public List<Esine> esineet;


        /// <summary>
        /// Ne paikat, joihin hahmolla on pääsy.
        /// Paikat joihin pääsyä ei tarvitse hakea
        /// ei luetella tässä. 
        /// </summary>
        Dictionary<Paikka, bool> paikatJohonPaasy;

        public Pelaaja(string nimi)
        {
            this.nimi = nimi;
            this.ominaisuudet = new Dictionary<string, int>()
            {
            };

            this.paikatJohonPaasy = new Dictionary<Paikka, bool>();
        }

        public void KaytaEsinetta(int kayttoVahennys)
        {

        }
    
        /// <summary>
        /// Laske onnellisuus
        /// </summary>
        internal void LaskeOnnellisuus()
        {
            // Tähän onnellisuuden laskukaava
            throw new NotImplementedException();
        }
    }
}

