using System.Collections.Generic;

namespace Elamasimu
{
    public class Paikka
    {
        /// <summary>
        /// Nimi.
        /// </summary>
        public string Nimi { get; private set; }


        /// <summary>
        /// Kauanko aikaa paikassa voi enintään olla.
        /// TODO: Tarvitaanko?
        /// </summary>
        public int MaxAika { get; private set; }
        
        /// <summary>
        /// Täytyykö paikkaan hakea pääsyä ennen kuin 
        /// siellä olevia aktiviteetteja voi tehdä.
        /// Esimerkiksi työpaikalla ei voi tehdä töitä,
        /// jos ei ole töissä siellä.
        /// </summary>
        public bool PitaakoPaikkaanHakea { get; private set; }

        /// <summary>
        /// Mitä painamalla pääsee mihinkin aktiviteettiin.
        /// </summary>
        public Dictionary<char, Aktiviteetti> LyhytValinnatJaAktiviteetit { get; private set; }
    }

}