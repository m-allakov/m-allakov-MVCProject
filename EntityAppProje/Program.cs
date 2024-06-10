

using EntityAppProje;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

internal class Program
{
    static void Main(string[] args)
    {
       
        using (var ctx = new OkulDBContext())
        {
            var lst = ctx.Ogrenciler.ToList();

            foreach (var item in lst)
            {
                Console.WriteLine(item.Ad);
            }
        }
    }
}




//Solid prensiplerine bak 
//Dependency injection
//Clean arcitehcture
//Web api lere bak

//Öğrenci işlemelri için menü ekleyelim
//Ders entitysi ekleyelim
//Öğrenciye ders ataması yapalım
//Tüm ekranlarda bootsrap kullanalım

//Öğrenci listesinde düzenle sil yanında aldığı dersler bölümü olacak.
//Ders entitysi olacak
//FLUENT APİ ile bu işlem yapılacak ders ve öğrenci arasında ilişki olacak