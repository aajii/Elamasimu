using System.Collections.Generic;

namespace Elamasimu
{
    /// <summary>
    /// Pelaaja
    /// </summary>
    public class Pelaaja
    {
        public string nimi;
        public Dictionary<string, int> ominaisuudet; 


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
                { "Raha", 0 },
                {  "Aly", 0 },
                {  "Fyysisyys", 0 },
                { "Sosiaalisuus", 0 },
                { "Ruokakyllaisyys", 0 }
            };

            this.paikatJohonPaasy = new Dictionary<Paikka, bool>();
        }
         /*   
            public int onnellisuus; // tarvitaanko tätä vai lasketaanko muista ?

        public int raha;

        public int aly;

        /// <summary>
        /// Fyysinen kunto ja ulkonäkö.
        /// </summary>
        public int fyysisyys;

        public int sosiaalisuus;

        /// <summary>
        /// Onko hahmolla nälkä (pienempi arvo)
        /// vai ei (suurempi arvo)
        /// </summary>
        public int ruokaKyllaisyys;
        */
    }

}

