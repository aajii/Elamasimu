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

        /// <summary>
        /// Onnellisuus.
        /// </summary>
        public int Onnellisuus
        {
            get;
            private set;
        }


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
            this.paikatJohonPaasy = new Dictionary<Paikka, bool>();
            this.ominaisuudet = new Ominaisuudet(this);
                
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

