using System.Collections.Generic;

namespace Elamasimu
{
    public class Aktiviteetti
    {
        public string kuvaus;
        public int aika;
        public int hinta;
        public int fyysisyys;
        public int aly;
        public int sosiaalisuus;
        public List<Saavutus> vaaditutSaavutukset;

        public Aktiviteetti(List<Saavutus> vaaditutSaavutukset, params int[])
        {

        }

    }



}