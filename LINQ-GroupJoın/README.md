# 👨‍🏫 LINQ GroupJoin ile Öğrencileri Sınıflarına Göre Gruplama

Bu proje, **LINQ GroupJoin** özelliğini kullanarak öğrencileri sınıflarına göre gruplamak ve terminalde bu grupları görüntülemek amacıyla geliştirilmiştir.

---

## 📜 Kod Hakkında

### 1️⃣ **Veri Listeleri**
Kodda iki temel veri listesi bulunmaktadır:

- **Sınıf Listesi (`Classes`)**: Sınıflar ve `ClassID` bilgileri içerir.
- **Öğrenci Listesi (`Students`)**: Öğrenciler ve onların `ClassID` bilgileri içerir.

---

### 2️⃣ **Grup Oluşturma**
`GroupJoin` metodu ile:
- Sınıflar ve öğrenciler, `ClassID` üzerinden eşleştirilir.
- Her sınıfa ait öğrenciler gruplandırılır.

---

### 3️⃣ **Ekran Çıktısı**
Kod, gruplandırılmış sonuçları terminale aşağıdaki formatta yazdırır:

```plaintext
 *** Sınıf : Matematik ***
Öğrenciler : Ali
Öğrenciler : Mehmet
-----------------------------------
 *** Sınıf : Türkçe ***
Öğrenciler : Ayşe
Öğrenciler : Ahmet
-----------------------------------
 *** Sınıf : Kimya ***
Öğrenciler : Fatma
-----------------------------------
```
# 🎯 Amaç
Bu proje, LINQ GroupJoin özelliğini öğrenmek ve uygulamak isteyenler için temel bir örnek sunar. 
### Özellikle :
Verilerin nasıl gruplandırılacağını,
İlişkili iki liste arasında bağ kurulacağını öğretir.
