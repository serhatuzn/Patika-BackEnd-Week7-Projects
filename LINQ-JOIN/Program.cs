using LINQ_JOIN;
using System;
using System.Collections.Generic;
using System.Linq;

List<Author> authors = new List<Author> // Yazar Listesini Oluşturup Yazarları üretiyoruz
{
    new Author { AuthorID = 1, Name = "Serhat" },
    new Author { AuthorID = 2, Name = "Elif" },
    new Author { AuthorID = 3, Name = "Barlas" },
    new Author { AuthorID = 4, Name = "Lina" },
};
List<Book> books = new List<Book> // Kitap Listesini Oluşturup Kitapları üretiyoruz
{
    new Book { BookID = 4, Title = "Başarı Yolu", AuthorID = 1},
    new Book { BookID = 5, Title = "Gurbet", AuthorID = 2},
    new Book { BookID = 6, Title = "İlk Evlat", AuthorID = 3},
    new Book { BookID = 7, Title = "Prenses", AuthorID = 4},
};

var query = from book in books  // Kitaplar ve yazarlar listelerini birleştiriyoruz (join işlemi).
            join author in authors on book.AuthorID equals author.AuthorID

            select new  // Yeni bir anonim tür oluşturup kitap başlığını ve yazar adını seçiyoruz.
            {
                BookTitle = book.Title,
                AuthorName = author.Name,
            };

foreach (var item in query)  // Birleştirilen veriyi döngüyle tek tek okuyup ekrana yazdırıyoruz.
{
    Console.WriteLine($"Kitap : {item.BookTitle} || Yazar : {item.AuthorName}");
}
