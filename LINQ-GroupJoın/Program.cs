using System.Threading.Tasks.Dataflow; // Gerekli değil, çıkarılabilir.
using LINQ_GroupJoın; // Kullanıcı tanımlı bir namespace gibi görünüyor, gerekliyse proje kapsamında tutulabilir.

// Öğrenci listesi tanımlanıyor.
List<Students> Student = new List<Students>
{
    new Students{ StudentID = 1, StudentName = "Ali", ClassID = 1},
    new Students{ StudentID = 2, StudentName = "Ayşe", ClassID = 2},
    new Students{ StudentID = 3, StudentName = "Mehmet", ClassID = 1},
    new Students{ StudentID = 4, StudentName = "Fatma", ClassID = 3},
    new Students{ StudentID = 5, StudentName = "Ahmet", ClassID = 2}
};

// Sınıf listesi tanımlanıyor.
List<Classes> Class = new List<Classes>
{
    new Classes { ClassID = 1, ClassName = "Matematik"},
    new Classes { ClassID = 2, ClassName = "Türkçe"},
    new Classes { ClassID = 3, ClassName = "Kimya"},
};

// GroupJoin kullanılarak sınıflar ve öğrenciler birleştiriliyor.
var result = Class.GroupJoin
(
    Student, // İkinci liste, birleştirilecek veri.
    classes => classes.ClassID, // Sınıf listesindeki eşleştirme anahtarı.
    students => students.ClassID, // Öğrenci listesindeki eşleştirme anahtarı.
    (classes, studentsGroup) => new // Her grup için yeni bir anonim nesne oluşturuluyor.
    {
        Classes = classes, // Sınıf nesnesini temsil eder.
        Students = studentsGroup.ToList() // Sınıfa ait öğrencilerin listesini içerir.
    }
);

// Sonuçlar ekrana yazdırılıyor.
foreach (var item in result)
{
    Console.WriteLine($" *** Sınıf : {item.Classes.ClassName} *** "); // Her sınıfın adı yazdırılıyor.
    foreach (var student in item.Students)
    {
        Console.WriteLine($"Öğrenciler : {student.StudentName}"); // Sınıfa ait öğrenciler yazdırılıyor.
    }
    Console.WriteLine("-----------------------------------");
}
