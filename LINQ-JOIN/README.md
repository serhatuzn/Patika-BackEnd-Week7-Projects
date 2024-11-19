# 📚 LINQ Join ile Kitap ve Yazar Eşleştirme

Bu proje, **LINQ Join** özelliğini kullanarak kitapları yazarlara eşleştiren ve bu veriyi terminalde gösteren bir örnektir. 

---

## 📜 Kod Hakkında

### 1️⃣ **Veri Listeleri**
Kodda iki temel veri listesi bulunmaktadır:

- **Yazar Listesi (`authors`)**: Yazarlar ve `AuthorID` bilgilerini içerir.
- **Kitap Listesi (`books`)**: Kitaplar, başlıkları ve onlara ait `AuthorID` bilgilerini içerir.

---

### 2️⃣ **Veri Birleştirme**
`join` anahtar kelimesi ile:
- Kitaplar ve yazarlar, `AuthorID` üzerinden birleştirilir.
- Her kitabın başlığı, ilgili yazarı ile eşleştirilir.

---

### 3️⃣ **Ekran Çıktısı**
Kod, birleştirilen veriyi terminale şu formatta yazdırır:

```plaintext
Kitap : Başarı Yolu || Yazar : Serhat
Kitap : Gurbet || Yazar : Elif
Kitap : İlk Evlat || Yazar : Barlas
Kitap : Prenses || Yazar : Lina
```
# 🎯 Amaç
Bu proje, LINQ join özelliğini öğrenmek isteyenler için temel bir örnek sunar. 
### Özellikle:
İlişkili iki liste arasında bağ kurmayı,
Anonim türler ile birleştirilen verileri kullanmayı öğretir.
