# LINQ Uygulama 🌟

Bu proje, C# dilinde LINQ (Language Integrated Query) kullanarak bazı temel veri manipülasyonlarını göstermektedir. LINQ, koleksiyonlardan veri seçmek, sıralamak, dönüştürmek ve filtrelemek için kullanılır.

## Kullanılan Özellikler

- **Where**: Belirli bir koşulu sağlayan öğeleri seçmek için kullanılır.
- **Select**: Koleksiyondaki öğeleri dönüştürmek (değiştirmek) için kullanılır.
- **Query Syntax**: LINQ sorgularını SQL benzeri bir sözdizimi ile yazma yöntemi.
- **Method Syntax**: LINQ sorgularını metotlar aracılığıyla yazma yöntemi.
- **OrderBy**: Listeyi belirli bir düzene göre sıralamak için kullanılır.

## Örnekler 📚

### 1. **Pozitif Sayılar** ✨

Pozitif sayıları seçmek için LINQ kullanarak aşağıdaki gibi bir sorgu yaptık:

```csharp
var PositiveNumbers = from number in numbers
                      where number > 0
                      select number;
```
### 2. Tek Sayılar (Odd Numbers) 🔢

Sadece tek sayıları almak için aşağıdaki sorguyu kullandık:

```csharp
var OddNumbers = from number in numbers
                 where number % 2 == 1
                 select number;
```
### 3. Negatif Sayılar (Negative Numbers) 🚫

Negatif sayıları filtrelemek için:

```csharp
var NegativeNumbers = numbers.Where(num => num < 0);
```

### 4. Pozitif Sayıları Küçükten Büyüğe Sıralama 🔝

Pozitif sayıları sıralamak için OrderBy kullandık:

```csharp
var PositiveSortedNumbers = from number in numbers
                            where number > 0
                            orderby number
                            select number;

```

### 5. 15 ile 22 Arasındaki Sayılar ⏳
 
15 ile 22 arasındaki sayıları seçmek için:
```csharp
var NumberBetween15and22 = numbers.Where(num => num > 15 && num < 22);
```

### 6. Sayılara Karesini Uygulamak 🔲

Sayılara karesini almak için Select kullandık:

```csharp
var squares = NewNumbers.Select(num => num * num);
```

# Sonuç 🎉
### Bu örnekte LINQ kullanarak veri manipülasyonlarını nasıl gerçekleştirebileceğinizi gösterdim. LINQ sayesinde, veriler üzerinde kolayca filtreleme, sıralama ve dönüştürme işlemleri yapabilirsiniz. Bu basit ama güçlü araç, veri işleme ve analiz konusunda büyük kolaylık sağlar!
