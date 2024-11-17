List<int> numbers = new List<int> { -12, -42, -23, 14, 55, 6, 17, 38, 9, 10 }; // Rastgele sayıları oluşturdum.

Console.WriteLine("---------------------------------------");
Console.WriteLine("*** Pozitif Sayılar ***");

var EvenNumbers = numbers.Where(num => num % 2 == 0); // Burda WHERE metodu ile çift sayı koşulunu belirtiyoruz

foreach (var num in EvenNumbers) // Çift sayıları Foreach döngüsü ile ekrana yazdırıyoruz. 
{
    Console.WriteLine(num);
}

Console.WriteLine("---------------------------------------");
Console.WriteLine("*** Tek Sayılar ***");

// Burada ise Query Syntax yani Sorgu Söz dizimi ile yapıldı 
var OddNumbers = from number in numbers // // Numbers listesindeki her öğeyi 'number' değişkenine atıyoruz.
                 where number % 2 == 1 // Tek sayı mı kontrolünü yapıyoruz WHERE ile 
                 select number; // SELECT ile Seçilen tek sayıları döndürüyoruz

foreach (var num in OddNumbers) // Seçilen tek sayıları FOREACH ekrana yazdırıyoruz.
{
    Console.WriteLine(num);
}

Console.WriteLine("---------------------------------------");
Console.WriteLine("*** Negatif Sayılar ***");

var NegativeNumbers = numbers.Where(num => num < 0); // Burada da metot söz dizimini kullandık sayı sıfırdan küçükse foreach ile yazdırıyoruz

foreach (var num in NegativeNumbers)
{
    Console.WriteLine(num);
}

Console.WriteLine("---------------------------------------");
Console.WriteLine("*** Pozitif Sayılar ***");
//sorgu söz dizimini kullandım burada da
var PozitiveNumber = from number in numbers
                     where number > 0 // Pozitif sayıları WHERE ile konrol etik.
                     orderby number // Küçükten büyüğe sıralamak için ORDER BY ASC kullandık
                     select number;

foreach (var num in PozitiveNumber)
{
    Console.WriteLine(num);
}

Console.WriteLine("---------------------------------------");
Console.WriteLine("*** 15 ile 22 arasındaki sayılar ***");

var Number = numbers.Where(num => num > 15 && num < 22); // 15 ile 22 arasındaki sayıları için yine Sorgu metodu şeklinde söz dizimi yaptım

foreach (var num in Number) // FOREACH ile yazdırıyoruz.
{
    System.Console.WriteLine(num);
}

Console.WriteLine("---------------------------------------");
Console.WriteLine("*** Listedeki her bir sayının karesi *** ");

List<int> NewNumbers = new List<int> { -1, -2, -3, 4, 5, 8, }; // Sayıların Karesi için yeni bir Liste oluşturuyorum

var squares = NewNumbers.Select(num => num * num); // num * num diyerek listedeki sayıyı kendisiyle çarparak karesini alıyoruz
/* WHERE yerine SELECT yapmamızın sebebi; SELECET her bir öğeye bir işlem uygulayarak yeni bir değer üretir. */
foreach (var num in squares)
{
    Console.WriteLine(num);
}