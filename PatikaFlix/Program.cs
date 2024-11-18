using Microsoft.VisualBasic;
using PatikaFlix;

List<Dizi> ShowList = new List<Dizi>();
bool dongu = true;

Console.WriteLine("**** PatikaFlix'e Hoşgeldin... ****");
Console.WriteLine("------------------------------------");
while (dongu) // Dongu
{
    // Burada direk kullanıcıdan alacağımız veriler var aslında
    Console.Write("Lütfen dizi ismi giriniz : "); // Kullanıcıdan dizinin ismini alıyoruz
    string diziAd = Console.ReadLine();

    Console.Write("Dizinin yapım yılını giriniz :  "); // Kullanıcıdan diznin Yapım yılını alıyoruz
    int yapımYılı = int.Parse(Console.ReadLine());

    Console.Write("Dizinin Türünü Giriniz (Komedi / Dram / Polisiye) : ");
    string diziTür = Console.ReadLine();

    Console.Write("Dizinin yayın yılını giriniz: ");
    int yayınYılı = int.Parse(Console.ReadLine());

    Console.Write("Dizinin yönetmenini giriniz: ");
    string yonetmen = Console.ReadLine();

    Console.Write("Dizinin yayınlandığı platformu giriniz: ");
    string platform = Console.ReadLine();

    Dizi yeniDizi = new Dizi(diziAd, yapımYılı, diziTür, yayınYılı, yonetmen, platform); // Kullanıcıdan alınan verileri yeni dizi şeklinde ekliyoruz
    ShowList.Add(yeniDizi);

    Console.Write("Yeni bir dizi Eklemek ister misin ? (e/h)"); // Yeni bir dizi eklemek ister misin diye soruyoruz evet derse döngüye girer hayır derse girilen verileri yazdırır..
    string devam = Console.ReadLine().ToLower();

    if (devam == "h")
    {
        break;
    }
}

var KomediListesi = from d in ShowList // Komedi türündeki diziler için yeni bir liste oluşturuyoruz
                    where d.DiziTür.ToLower() == "komedi" // Dizi türü komedi olanlar için koşul koyuyoruz
                    orderby d.DiziAd, d.Yonetmen
                    select new Komedi(d.DiziAd, d.DiziTür, d.Yonetmen);

Console.WriteLine("------------------------------------");
Console.WriteLine("*** Komedi Dizileri ***"); // Kullanıcıdan alınan bilgilerden içinde Türü Komedi olanları yazdırıyoruz.
foreach (var komedi in KomediListesi)
{
    Console.WriteLine(komedi);
}

// Komedi olmayan türdeki dizileri filtreliyoruz
var KomediOlmayanListesi = from d in ShowList
                           where d.DiziTür.ToLower() != "komedi" // "komedi" olmayan diziler
                           orderby d.DiziAd, d.Yonetmen
                           select new Komedi(d.DiziAd, d.DiziTür, d.Yonetmen);

Console.WriteLine("------------------------------------");
Console.WriteLine("*** Komedi Türü Olmayan Diziler ***");
foreach (var dizi in KomediOlmayanListesi)
{
    Console.WriteLine(dizi);
}