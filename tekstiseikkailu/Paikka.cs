using System.Collections.Generic;

namespace Elamasimu
{
    public class Paikka
    {
        public string nimi;

        /// <summary>
        /// Mitä kirjainta painamalla pääsee paikkaan
        /// </summary>
        public char lyhytvalinta;

        public int maxAika;
        
        /// <summary>
        /// Täytyykö paikkaan hakea pääsyä ennen kuin 
        /// siellä olevia aktiviteetteja voi tehdä.
        /// Esimerkiksi työpaikalla ei voi tehdä töitä,
        /// jos ei ole töissä siellä.
        /// </summary>
        public bool pitaakoPaikkaanHakea;

        public List<Aktiviteetti> aktiviteetit;
    }

}