using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elamasimu
{
    class Ominaisuudet
    {
        private Pelaaja pelaaja;


        int raha = 0;
        int aly = 0;
        int fyysisyys = 0;
        int sosiaalisuus = 0;
        int ruoka = 0;

        /// <summary>
        /// Raha.
        /// </summary>
        public int Raha
        {
            get { return raha; }
            set
            {
                raha = value;
                pelaaja.LaskeOnnellisuus();
            }
        }

        /// <summary>
        /// Äly.
        /// </summary>
        public int Aly
        {
            get { return aly; }
            set
            {
                aly = value;
                pelaaja.LaskeOnnellisuus();
            }
        }

        /// <summary>
        /// Ulkonäkö ja fyysinen kunto.
        /// </summary>
        public int Fyysisyys
        {
            get
            {
                return fyysisyys;
            }
            set
            {
                fyysisyys = value;
                pelaaja.LaskeOnnellisuus();
            }
        }

        /// <summary>
        /// Sosiaalisuus.
        /// </summary>
        public int Sosiaalisuus
        {
            get { return sosiaalisuus; }
            set
            {
                sosiaalisuus = value;
                pelaaja.LaskeOnnellisuus();
            }
        }

        /// <summary>
        /// Ruoan tarve.
        /// </summary>
        public int Ruoka
        {
            get { return ruoka; }
            set
            {
                ruoka = value;
                pelaaja.LaskeOnnellisuus();
            }
        }

        /// <summary>
        /// Ominaisuudet.
        /// </summary>
        /// <param name="pelaaja">Pelaaja.</param>
        public Ominaisuudet(Pelaaja pelaaja)
        {
            this.pelaaja = pelaaja;
        }
    }
}
