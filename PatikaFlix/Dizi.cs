using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatikaFlix
{
    public class Dizi
    {
        public string DiziAd { get; set; }
        public int YapımYılı { get; set; }
        public string DiziTür { get; set; }
        public int YayınYılı { get; set; }
        public string Yonetmen { get; set; }
        public string Platform { get; set; }

        public Dizi(string diziAd, int yapımYılı, string diziTür, int yayınYılı, string yonetmen, string platform)
        {
            DiziAd = diziAd;
            YapımYılı = yapımYılı;
            DiziTür = diziTür;
            YayınYılı = yayınYılı;
            Yonetmen = yonetmen;
            Platform = platform;
        }

        public override string ToString()
        {
            return $"Dizi Adı: {DiziAd} || Tür: {DiziTür} || Yönetmen: {Yonetmen}";
        }
    }
}
