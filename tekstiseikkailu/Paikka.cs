using System.Collections.Generic;

namespace Elamasimu
{
    public class Paikka
    {
        public string nimi;

        /// <summary>
        /// Mitä kirjainta painamalla pääsee paikkaan
        /// </summary>
        public char lyhytvalinta; // TODO: Ei pitäisi sekoittaa kontrollien toimintaa tähän. Paranna.

        public int maxAika;
        
        /// <summary>
        /// Täytyykö paikkaan hakea pääsyä ennen kuin 
        /// siellä olevia aktiviteetteja voi tehdä.
        /// Esimerkiksi työpaikalla ei voi tehdä töitä,
        /// jos ei ole töissä siellä.
        /// </summary>
        public bool pitaakoPaikkaanHakea;

        /// <summary>
        /// Mitä painamalla pääsee mihinkin aktiviteettiin.
        /// </summary>
        public Dictionary<char, Aktiviteetti> lyhytValinnatJaAktiviteetit;
    }

}