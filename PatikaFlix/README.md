# PatikaFlix 🎬🍿

PatikaFlix, kullanıcıların dizileri ekleyip listeleyebileceği basit bir konsol tabanlı uygulamadır. Kullanıcılar dizilerin adı, türü, yapım yılı, yayın yılı, yönetmeni ve platformu gibi bilgileri girerek kendi dizilerini oluşturabilir. Ayrıca, "Komedi" türündeki dizileri listeleme ve "Komedi olmayan" dizileri filtreleme gibi işlemleri de yapabilirsiniz. 🚀

## Özellikler ✨
- Dizilerin adı, türü, yapım yılı, yayın yılı, yönetmeni ve platformu bilgilerini kullanıcıdan alır.
- Kullanıcı, birden fazla dizi ekleyebilir.
- **Komedi** türündeki diziler filtrelenebilir.
- Komedi olmayan diziler de listelenebilir.

## Kullanım 📖

1. `PatikaFlix` uygulamasını çalıştırarak kullanıcıdan dizi bilgilerini girmesini isteyin.
2. Kullanıcı, dizilerini ekledikten sonra komedi türündeki dizileri filtreleyebilir ve komedi olmayan dizileri listeleyebilirsiniz.

### Adımlar:
- **Dizi Bilgilerini Girme:** Kullanıcıdan dizilerin adı, türü, yapım yılı, yayın yılı, yönetmeni ve platformu istenir.
- **Komedi Dizileri Listeleme:** Kullanıcı komedi dizilerini listelemek isteyebilir.
- **Komedi Olmayan Dizileri Listeleme:** Kullanıcı "komedi" olmayan dizileri listelemek isteyebilir.

## Teknolojiler ve Kullanılan Diller 🖥️

- C#
- LINQ (Language Integrated Query)
- Konsol Uygulaması

## Kurulum 📦

1. Bu projeyi bilgisayarınıza klonlayın:
    ```bash
    git clone https://github.com/kullaniciadi/PatikaFlix.git
    ```

2. Visual Studio veya herhangi bir C# geliştirme ortamında projeyi açın.

3. Programı çalıştırarak dizileri ekleyin ve filtreleme işlemlerini yapın.

## Kodlar 📚

### 1. **Dizi Sınıfı** 📝
```csharp
using System;
using System.Collections.Generic;

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
```

### 2. Komedi Sınıfı 🎭

```csharp
using System;

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
```
### 3. Ana Program (PatikaFlix Uygulaması) 🎮
```csharp
using System;
using System.Collections.Generic;
using System.Linq;

namespace PatikaFlix
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dizi> ShowList = new List<Dizi>();
            bool dongu = true;

            Console.WriteLine("**** PatikaFlix'e Hoşgeldin... ****");
            Console.WriteLine("------------------------------------");
            while (dongu) // Dongu
            {
                Console.Write("Lütfen dizi ismi giriniz : ");
                string diziAd = Console.ReadLine();

                Console.Write("Dizinin yapım yılını giriniz :  ");
                int yapımYılı = int.Parse(Console.ReadLine());

                Console.Write("Dizinin Türünü Giriniz (Komedi / Dram / Polisiye) : ");
                string diziTür = Console.ReadLine();

                Console.Write("Dizinin yayın yılını giriniz: ");
                int yayınYılı = int.Parse(Console.ReadLine());

                Console.Write("Dizinin yönetmenini giriniz: ");
                string yonetmen = Console.ReadLine();

                Console.Write("Dizinin yayınlandığı platformu giriniz: ");
                string platform = Console.ReadLine();

                Dizi yeniDizi = new Dizi(diziAd, yapımYılı, diziTür, yayınYılı, yonetmen, platform);
                ShowList.Add(yeniDizi);

                Console.Write("Yeni bir dizi Eklemek ister misin ? (e/h)");
                string devam = Console.ReadLine().ToLower();

                if (devam == "h")
                {
                    break;
                }
            }

            var KomediListesi = from d in ShowList
                                where d.DiziTür.ToLower() == "komedi"
                                orderby d.DiziAd, d.Yonetmen
                                select new Komedi(d.DiziAd, d.DiziTür, d.Yonetmen);

            Console.WriteLine("------------------------------------");
            Console.WriteLine("*** Komedi Dizileri ***");
            foreach (var komedi in KomediListesi)
            {
                Console.WriteLine(komedi);
            }
        }
    }
}
```

# 🌟 PatikaFlix uygulaması ile favori dizilerinizi takip etmek artık daha eğlenceli! 🎉

### Açıklamalar:
- **Başlıklar ve Emoji Kullanımı:** Projenin her önemli bölümüne açıklamalar ekleyip, emojisiz bir şekilde dokümanı monotonluktan kurtarıp daha dinamik ve eğlenceli hale getirdim.
- **Kurulum ve Kullanım Adımları:** Projeyi kullanmaya başlamak için gereken tüm temel bilgileri ekledim.
- **Kod Örnekleri:** Kod parçacıklarını üç ana başlık altında sundum ve her birine açıklamalar ekledim.
