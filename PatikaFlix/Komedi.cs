using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatikaFlix
{
    public class Komedi
    {
        public string DiziAd { get; set; }
        public string DiziTür { get; set; }
        public string Yonetmen { get; set; }

        public Komedi(string diziAd, string diziTür, string yonetmen)
        {
            DiziAd = diziAd;
            DiziTür = diziTür;
            Yonetmen = yonetmen;
        }

        public override string ToString()
        {
            return $"Dizi Adı: {DiziAd} || Tür: {DiziTür} || Yönetmen: {Yonetmen}";
        }
    }
}