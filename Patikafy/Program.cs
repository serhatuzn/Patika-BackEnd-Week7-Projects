using System.Runtime.ExceptionServices;
using Patikafy;

Console.WriteLine("----------------------------------------------------");

List<Artists> artists = new List<Artists> // Liste Oluşturup elemanları ekliyoruz.
{
    new Artists("Ajda Pekkan", "Pop", 1968, 20000000),
    new Artists("Sezen Aksu", "Türk Halk Müziği / Pop", 1971, 10000000),
    new Artists("Funda Arar", "Pop", 1999, 3000000),
    new Artists("Sertab Erener", "Pop", 1994, 5000000),
    new Artists("Sıla", "Pop", 2009, 3000000),
    new Artists("Serdar Ortaç", "Pop", 1994, 10000000),
    new Artists("Tarkan", "Pop", 1999, 40000000),
    new Artists("Hande Yener", "Pop", 1999, 7000000),
    new Artists("Hadise", "Pop", 2005, 5000000),
    new Artists("Gülben Ergen", "Pop / Türk Halk Müziği", 1997, 10000000),
    new Artists("Neşet Ertaş", "Türk Halk Müziği / Türk Sanat Müziği", 1960, 2000000),
};

var NameStartWithS = from artist in artists // LINQ sorgu sözdizimi ile filtreleme yapıyoruz.
                     where artist.ArtistName.StartsWith("S")
                     select artist;

Console.WriteLine($"*** Adı S ile başlıyan şarkıcalar ***");
foreach (var artist in NameStartWithS)
{
    Console.WriteLine($"Şarkıcı Adı : {artist.ArtistName}");
}

Console.WriteLine("----------------------------------------------------");
Console.WriteLine($"*** Albüm Satışları 10 Milyonun üzerinde olan şarkıcalar ***");

var AlbumSales = from artist in artists // LINQ sorgu sözdizimi ile ALbüm satışlarına göre filtreliyoruz.
                 where artist.AlbumSales > 10000000
                 select artist;

foreach (var artist in AlbumSales)
{
    Console.WriteLine($"Şarkıcı Adı : {artist.ArtistName}");
}

Console.WriteLine("----------------------------------------------------");
Console.WriteLine($"*** 2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar.  ***");

// 2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcıları filtreliyoruz
var MusicYear = from artist in artists
                where artist.MusicYear < 2000 && artist.MusicType == "Pop" // Yıl 2000'den önce olmalı ve müzik türü Pop olmalı
                orderby artist.ArtistName, artist.MusicYear // Önce sanatçının adını alfabetik sıraya göre, sonra çıkış yılını sıralıyoruz
                select artist;

// Listeyi döngü ile yazdırıyoruz
foreach (var artist in MusicYear)
{
    Console.WriteLine($"Şarkıcı Adı : {artist.ArtistName} || Çıkış Yılı : {artist.MusicYear}");
}

Console.WriteLine("----------------------------------------------------");
Console.WriteLine($"*** En çok albüm satan şarkıcı  ***");

// Albüm satışlarına göre en çok satan sanatçıyı buluyoruz
var albumSales = artists.OrderByDescending(s => s.AlbumSales).First(); // Satış sayısına göre azalan sırayla sıralayıp ilkini alıyoruz

if (albumSales != null) // Eğer sanatçı bulunursa
{
    Console.WriteLine($"En çok albüm satan şarkıcı: {albumSales.ArtistName} || Albüm Satışı: {albumSales.AlbumSales}");
}

Console.WriteLine("----------------------------------------------------");
Console.WriteLine($"*** En yeni çıkış yapan şarkıcı ve en eski çıkış yapan şarkıcı ***");

// En yeni çıkış yapan sanatçıyı buluyoruz
var NewArtist = (from artist in artists
                 orderby artist.MusicYear descending // En yeni sanatçı ilk sırada olacak
                 select artist).First(); // İlk sanatçıyı alıyoruz (en yeni)

// En eski çıkış yapan sanatçıyı buluyoruz
var LastArtist = (from artist in artists
                  orderby artist.MusicYear ascending // En eski sanatçı ilk sırada olacak
                  select artist).First(); // İlk sanatçıyı alıyoruz (en eski)

// En yeni ve en eski sanatçıyı yazdırıyoruz
Console.WriteLine($"En yeni çıkış yapan şarkıcı : {NewArtist.ArtistName} || Çıkış yaptığı yıl : {NewArtist.MusicYear} \r\nEn eski çıkış yapan şarkıcı : {LastArtist.ArtistName} || Çıkış yaptığı yıl : {LastArtist.MusicYear}");
